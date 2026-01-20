namespace C_sharp_lever_2
{
    partial class ctlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(34, 165);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(36, 25);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "??";
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Image = global::C_sharp_lever_2.Properties.Resources.Red;
            this.pbTrafficLight.Location = new System.Drawing.Point(3, 3);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(100, 150);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrafficLight.TabIndex = 0;
            this.pbTrafficLight.TabStop = false;
            // 
            // ctlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.pbTrafficLight);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "ctlTrafficLight";
            this.Size = new System.Drawing.Size(107, 201);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Label lblCountDown;
    }
}
