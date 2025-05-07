namespace need_for_speed
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            navBar = new Panel();
            button7 = new Button();
            login = new Button();
            menu = new Button();
            pictureBox1 = new PictureBox();
            update = new Button();
            panelAdd = new Panel();
            textBoxSSN = new TextBox();
            labelSSN = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            panelOrders = new Panel();
            lblOrderHistory = new Label();
            dataGridViewOrders = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAdd.SuspendLayout();
            panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // navBar
            // 
            navBar.BackColor = SystemColors.ActiveCaption;
            navBar.Controls.Add(button7);
            navBar.Controls.Add(login);
            navBar.Controls.Add(menu);
            navBar.Controls.Add(pictureBox1);
            navBar.Location = new Point(0, -2);
            navBar.Name = "navBar";
            navBar.Size = new Size(1202, 93);
            navBar.TabIndex = 0;
            navBar.Paint += navBar_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(33, 52, 72);
            button7.Location = new Point(381, 12);
            button7.Margin = new Padding(3, 6, 3, 6);
            button7.Name = "button7";
            button7.Size = new Size(122, 84);
            button7.TabIndex = 9;
            button7.Text = "Contact us";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.FlatAppearance.BorderSize = 0;
            login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = Color.FromArgb(33, 52, 72);
            login.Location = new Point(240, 18);
            login.Margin = new Padding(3, 6, 3, 6);
            login.Name = "login";
            login.Size = new Size(122, 63);
            login.TabIndex = 7;
            login.Text = "Log out";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menu.ForeColor = Color.FromArgb(33, 52, 72);
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(103, 0);
            menu.Margin = new Padding(3, 6, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(117, 109);
            menu.TabIndex = 4;
            menu.Text = "Home";
            menu.TextAlign = ContentAlignment.MiddleRight;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // update
            // 
            update.BackColor = Color.MediumSeaGreen;
            update.Location = new Point(173, 472);
            update.Name = "update";
            update.Size = new Size(272, 63);
            update.TabIndex = 1;
            update.Text = "Update Profile";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(update);
            panelAdd.Controls.Add(textBoxSSN);
            panelAdd.Controls.Add(labelSSN);
            panelAdd.Controls.Add(textBoxAddress);
            panelAdd.Controls.Add(labelAddress);
            panelAdd.Controls.Add(textBoxPassword);
            panelAdd.Controls.Add(labelPassword);
            panelAdd.Controls.Add(textBoxUsername);
            panelAdd.Controls.Add(labelUsername);
            panelAdd.Location = new Point(0, 91);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(632, 607);
            panelAdd.TabIndex = 3;
            // 
            // textBoxSSN
            // 
            textBoxSSN.Location = new Point(194, 171);
            textBoxSSN.Name = "textBoxSSN";
            textBoxSSN.Size = new Size(238, 27);
            textBoxSSN.TabIndex = 25;
            // 
            // labelSSN
            // 
            labelSSN.AutoSize = true;
            labelSSN.BackColor = SystemColors.ButtonFace;
            labelSSN.Location = new Point(125, 171);
            labelSSN.Name = "labelSSN";
            labelSSN.Size = new Size(36, 20);
            labelSSN.TabIndex = 24;
            labelSSN.Text = "SSN";
            labelSSN.Click += labelColor_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(194, 260);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(238, 149);
            textBoxAddress.TabIndex = 23;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = SystemColors.ButtonFace;
            labelAddress.Location = new Point(103, 263);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 22;
            labelAddress.Text = "Address";
            labelAddress.Click += labelDescription_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(194, 111);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(238, 27);
            textBoxPassword.TabIndex = 19;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = SystemColors.ButtonFace;
            labelPassword.Location = new Point(113, 114);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 18;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(194, 34);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(238, 27);
            textBoxUsername.TabIndex = 17;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.ButtonFace;
            labelUsername.Location = new Point(113, 37);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 16;
            labelUsername.Text = "Username";
            labelUsername.Click += labelBrand_Click;
            // 
            // panelOrders
            // 
            panelOrders.BackColor = Color.FromArgb(240, 240, 240);
            panelOrders.BorderStyle = BorderStyle.FixedSingle;
            panelOrders.Controls.Add(lblOrderHistory);
            panelOrders.Controls.Add(dataGridViewOrders);
            panelOrders.Location = new Point(638, 112);
            panelOrders.Name = "panelOrders";
            panelOrders.Size = new Size(550, 500);
            panelOrders.TabIndex = 4;
            // 
            // lblOrderHistory
            // 
            lblOrderHistory.AutoSize = true;
            lblOrderHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderHistory.ForeColor = Color.DarkSlateBlue;
            lblOrderHistory.Location = new Point(20, 20);
            lblOrderHistory.Name = "lblOrderHistory";
            lblOrderHistory.Size = new Size(228, 28);
            lblOrderHistory.TabIndex = 0;
            lblOrderHistory.Text = "YOUR ORDER HISTORY";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrders.ColumnHeadersHeight = 29;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewOrders.EnableHeadersVisualStyles = false;
            dataGridViewOrders.Location = new Point(20, 60);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(510, 420);
            dataGridViewOrders.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Order #";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Vehicle";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Rental Dates";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Total Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 696);
            Controls.Add(panelAdd);
            Controls.Add(navBar);
            Controls.Add(panelOrders);
            Name = "profile";
            Text = "profile";
            Load += Form1_Load;
            navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelOrders.ResumeLayout(false);
            panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navBar;
        private PictureBox pictureBox1;
        private Button update;
        private Panel panelAdd;
        private TextBox textBoxSSN;
        private Label labelSSN;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private DataGridView dataGridViewOrders;
        private Label lblOrderHistory;
        private Panel panelOrders;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button menu;
        private Button button7;
        private Button login;
    }
}