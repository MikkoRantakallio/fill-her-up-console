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
    public partial class FillingForm : Form
    {
        public FillingForm(Filling selectedFilling)
        {
            InitializeComponent();
            fillingTime.Value = Convert.ToDateTime(selectedFilling.date);
            fillingLicense.Text = selectedFilling.license;
            fillingPrice.Text = selectedFilling.price.ToString("F2");
            fillingAmount.Text = selectedFilling.amount.ToString("F2");
            fillingMileage.Text = selectedFilling.mileage.ToString();
        }
    }
}
