namespace PyxisAirGroupProject
{
    partial class MainForm
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
            this.CustBTN = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.FlightBTN = new System.Windows.Forms.Button();
            this.RSVBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustBTN
            // 
            this.CustBTN.Location = new System.Drawing.Point(155, 137);
            this.CustBTN.Name = "CustBTN";
            this.CustBTN.Size = new System.Drawing.Size(181, 74);
            this.CustBTN.TabIndex = 0;
            this.CustBTN.Text = "Customer Form";
            this.CustBTN.UseVisualStyleBackColor = true;
            this.CustBTN.Click += new System.EventHandler(this.CustBTN_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(371, 258);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(171, 68);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            // 
            // FlightBTN
            // 
            this.FlightBTN.Location = new System.Drawing.Point(371, 137);
            this.FlightBTN.Name = "FlightBTN";
            this.FlightBTN.Size = new System.Drawing.Size(171, 74);
            this.FlightBTN.TabIndex = 2;
            this.FlightBTN.Text = "Flight Form";
            this.FlightBTN.UseVisualStyleBackColor = true;
            // 
            // RSVBTN
            // 
            this.RSVBTN.Location = new System.Drawing.Point(155, 258);
            this.RSVBTN.Name = "RSVBTN";
            this.RSVBTN.Size = new System.Drawing.Size(181, 68);
            this.RSVBTN.TabIndex = 3;
            this.RSVBTN.Text = "Reservation Form";
            this.RSVBTN.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 513);
            this.Controls.Add(this.RSVBTN);
            this.Controls.Add(this.FlightBTN);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.CustBTN);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustBTN;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button FlightBTN;
        private System.Windows.Forms.Button RSVBTN;
    }
}