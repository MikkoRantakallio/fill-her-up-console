using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillHerUp
{
    public partial class FillHerUp : Form
    {
        CarListReader CarList;
        FillingListReader FillingList;

        public FillHerUp()
        {
            InitializeComponent();
        }

        private void FillHerUp_Load(object sender, EventArgs e)
        {
            // Fill Car Combo
            CarList = new CarListReader();
            foreach (Car car in CarList.Cars)
            {
                comboBoxCars.Items.Add(car.license);
            }

            // Setup filling list view
            listViewFillings.View = View.Details;
            listViewFillings.GridLines = true;
            listViewFillings.FullRowSelect = true;

            listViewFillings.Columns.Add("Date", 125);
            listViewFillings.Columns.Add("Amount", 70, HorizontalAlignment.Right);
            listViewFillings.Columns.Add("Price", 70, HorizontalAlignment.Right);
            listViewFillings.Columns.Add("Mileage", 150, HorizontalAlignment.Right);
        }

        private void comboBoxCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Show car description
            int ind = comboBoxCars.SelectedIndex;
            string desc = CarList.Cars[ind].description;
            textBoxCarDesc.Text = desc;

            // Clear the filling list first
            listViewFillings.Items.Clear();
            listViewFillings.Refresh();

            // Get new list and show it
            FillingList = new FillingListReader(CarList.Cars[ind].license);
            foreach (Filling fill in FillingList.Fillings)
            {
                string[] arr = new string[5];

                // Convert date
                string fillDate = fill.date.Substring(fill.date.Length - 2, 2) + ".";
                fillDate += fill.date.Substring(fill.date.Length - 5, 2) + ".";
                fillDate += fill.date.Substring(0,4);

                arr[0] = fillDate;
                arr[1] = fill.amount.ToString("00.00");
                arr[2] = fill.price.ToString("00.00");
                arr[3] = fill.mileage.ToString();
                arr[4] = fill.id.ToString();

                ListViewItem item;
                item = new ListViewItem(arr);

                listViewFillings.Items.Add(item);
            }
        }

        private void fillingButton_Click(object sender, EventArgs e)
        {
            if (listViewFillings.SelectedItems.Count == 1)
            {
                var ind = listViewFillings.SelectedItems[0].Index;

                FillingForm frm = new FillingForm(FillingList.Fillings[ind]);
                frm.ShowDialog();

                listViewFillings.SelectedItems.Clear();
            }
            else
            {
                string message = "Please, select a filling row.";
                string caption = "No selection!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
