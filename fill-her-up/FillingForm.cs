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
        }
    }
}
