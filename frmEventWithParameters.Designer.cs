namespace C_sharp_lever_2
{
    partial class frmEventWithParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlCimpleCals1 = new C_sharp_lever_2.ctlCimpleCals();
            this.SuspendLayout();
            // 
            // ctlCimpleCals1
            // 
            this.ctlCimpleCals1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctlCimpleCals1.Location = new System.Drawing.Point(29, -15);
            this.ctlCimpleCals1.Name = "ctlCimpleCals1";
            this.ctlCimpleCals1.Size = new System.Drawing.Size(436, 213);
            this.ctlCimpleCals1.TabIndex = 0;
            this.ctlCimpleCals1.OnCalculationComplete += new System.EventHandler<C_sharp_lever_2.ctlCimpleCals.CalculationCompleteEventArgs>(this.ctlCimpleCals1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 274);
            this.Controls.Add(this.ctlCimpleCals1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlCimpleCals ctlCimpleCals1;
    }
}

