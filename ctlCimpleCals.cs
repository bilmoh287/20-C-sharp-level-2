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
    public partial class ctlCimpleCals : UserControl
    {
        public ctlCimpleCals()
        {
            InitializeComponent();
        }

        public class CalculationCompleteEventArgs : EventArgs
        { 
            public int Val1 { get; }
            public int Val2 { get; }
            public int Result { get; }

            public CalculationCompleteEventArgs(int Val1, int Val2, int Result)
            {
                this.Val1 = Val1;
                this.Val2 = Val2;
                this.Result = Result;
            }
        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;
        protected virtual void RaisedOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }
        public void RaisedOnCalculationComplete(int val1, int val2, int result)
        {
            RaisedOnCalculationComplete(new CalculationCompleteEventArgs(val1, val2, result));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;

            val1 = Convert.ToInt32(textBox1.Text);
            val2 = Convert.ToInt32(textBox2.Text);
            int result = val1 + val2;
            lblResult.Text = result.ToString();

            RaisedOnCalculationComplete(val1, val2, result);
        }
    }
}
