using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_lever_2
{
    public partial class frmEventWithParameters : Form
    {
        public frmEventWithParameters()
        {
            InitializeComponent();
        }

        private void ctlCimpleCals1_OnCalculationComplete(object sender, ctlCimpleCals.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"Result = {e.Result} val1 = {e.Val1}, val2 = {e.Val2}");
        }
    }
}
