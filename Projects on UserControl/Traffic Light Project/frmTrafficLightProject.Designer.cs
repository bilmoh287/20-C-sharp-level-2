namespace Projects_on_UserControl
{
    partial class frmTrafficLightProject
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
            this.ctlTrafficLight1 = new Projects_on_UserControl.ctlTrafficLight();
            this.SuspendLayout();
            // 
            // ctlTrafficLight1
            // 
            this.ctlTrafficLight1.CurrentLight = Projects_on_UserControl.ctlTrafficLight.enLightType.Red;
            this.ctlTrafficLight1.GreemTime = 10;
            this.ctlTrafficLight1.Location = new System.Drawing.Point(130, 110);
            this.ctlTrafficLight1.Name = "ctlTrafficLight1";
            this.ctlTrafficLight1.OrangeTime = 3;
            this.ctlTrafficLight1.RedTime = 10;
            this.ctlTrafficLight1.Size = new System.Drawing.Size(95, 209);
            this.ctlTrafficLight1.TabIndex = 0;
            this.ctlTrafficLight1.LightChanged += new System.EventHandler<Projects_on_UserControl.ctlTrafficLight.TrafficLightEventArgs>(this.ctlTrafficLight1_LightChanged);
            // 
            // frmTrafficLightProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlTrafficLight1);
            this.Name = "frmTrafficLightProject";
            this.Text = "frmTrafficLightProject";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlTrafficLight ctlTrafficLight1;
    }
}