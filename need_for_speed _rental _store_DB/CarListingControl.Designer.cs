namespace DisplayCars
{
    partial class CarListingControl
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
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.circlePanel = new System.Windows.Forms.Panel();
            this.lblCatConstant = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblPassengersIcon = new System.Windows.Forms.Label();
            this.lblLuggageIcon = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.lblLuggage = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.circlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(250, 180);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // circlePanel
            // 
            this.circlePanel.BackColor = System.Drawing.Color.Purple;
            this.circlePanel.Controls.Add(this.lblCatConstant);
            this.circlePanel.Location = new System.Drawing.Point(290, 25);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(24, 24);
            this.circlePanel.TabIndex = 1;
            // 
            // lblCatConstant
            // 
            this.lblCatConstant.AutoSize = true;
            this.lblCatConstant.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCatConstant.Location = new System.Drawing.Point(4, 5);
            this.lblCatConstant.Name = "lblCatConstant";
            this.lblCatConstant.Size = new System.Drawing.Size(17, 16);
            this.lblCatConstant.TabIndex = 0;
            this.lblCatConstant.Text = "C";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCarType.Location = new System.Drawing.Point(320, 30);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(63, 16);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Compact";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.ForeColor = System.Drawing.Color.Purple;
            this.lblCarName.Location = new System.Drawing.Point(290, 60);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(248, 24);
            this.lblCarName.TabIndex = 3;
            this.lblCarName.Text = "Hyundai Grand i10 2024";
            // 
            // lblPassengersIcon
            // 
            this.lblPassengersIcon.AutoSize = true;
            this.lblPassengersIcon.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPassengersIcon.Location = new System.Drawing.Point(290, 110);
            this.lblPassengersIcon.Name = "lblPassengersIcon";
            this.lblPassengersIcon.Size = new System.Drawing.Size(86, 16);
            this.lblPassengersIcon.TabIndex = 4;
            this.lblPassengersIcon.Text = "Passengers:";
            this.lblPassengersIcon.Click += new System.EventHandler(this.lblPassengersIcon_Click);
            // 
            // lblLuggageIcon
            // 
            this.lblLuggageIcon.AutoSize = true;
            this.lblLuggageIcon.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLuggageIcon.Location = new System.Drawing.Point(407, 110);
            this.lblLuggageIcon.Name = "lblLuggageIcon";
            this.lblLuggageIcon.Size = new System.Drawing.Size(67, 16);
            this.lblLuggageIcon.TabIndex = 5;
            this.lblLuggageIcon.Text = "Luggage:";
            this.lblLuggageIcon.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTransmission.Location = new System.Drawing.Point(501, 110);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(94, 16);
            this.lblTransmission.TabIndex = 6;
            this.lblTransmission.Text = "Transmission:";
            this.lblTransmission.Click += new System.EventHandler(this.lblTransmission_Click);
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPassengers.Location = new System.Drawing.Point(376, 110);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(15, 16);
            this.lblPassengers.TabIndex = 7;
            this.lblPassengers.Text = "4";
            this.lblPassengers.Click += new System.EventHandler(this.lblPassengers_Click);
            // 
            // lblLuggage
            // 
            this.lblLuggage.AutoSize = true;
            this.lblLuggage.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLuggage.Location = new System.Drawing.Point(470, 110);
            this.lblLuggage.Name = "lblLuggage";
            this.lblLuggage.Size = new System.Drawing.Size(15, 16);
            this.lblLuggage.TabIndex = 8;
            this.lblLuggage.Text = "2";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTrans.Location = new System.Drawing.Point(592, 110);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(16, 16);
            this.lblTrans.TabIndex = 9;
            this.lblTrans.Text = "A";
            this.lblTrans.Click += new System.EventHandler(this.lblTrans_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Purple;
            this.lblPrice.Location = new System.Drawing.Point(770, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(101, 26);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "500 EGP";
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.Purple;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(750, 150);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(150, 40);
            this.btnBookNow.TabIndex = 11;
            this.btnBookNow.Text = "BOOK NOW";
            this.btnBookNow.UseVisualStyleBackColor = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // CarListingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.lblLuggage);
            this.Controls.Add(this.lblPassengers);
            this.Controls.Add(this.lblTransmission);
            this.Controls.Add(this.lblLuggageIcon);
            this.Controls.Add(this.lblPassengersIcon);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.circlePanel);
            this.Controls.Add(this.pictureBoxCar);
            this.Name = "CarListingControl";
            this.Size = new System.Drawing.Size(930, 230);
            this.Load += new System.EventHandler(this.CarListingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.circlePanel.ResumeLayout(false);
            this.circlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Panel circlePanel;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblCatConstant;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblPassengersIcon;
        private System.Windows.Forms.Label lblLuggageIcon;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label lblLuggage;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBookNow;
    }
}
