using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vehicle_rental_store
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panelcategories = new Panel();
            tableLayoutPanellogo = new TableLayoutPanel();
            ourcategoreis = new Label();
            catenaem = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            sed = new Label();
            button1 = new Button();
            sedan = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            su = new Label();
            button2 = new Button();
            suv = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            luxury = new Label();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            button4 = new Button();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            panel9 = new Panel();
            button5 = new Button();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            panel10 = new Panel();
            button6 = new Button();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            mainpanel = new Panel();
            paneltop = new Panel();
            panelCalendar = new Panel();
            cityreturn = new ComboBox();
            cityComboBox = new ComboBox();
            returnDifferentCheckBox = new CheckBox();
            pickupDatePicker = new DateTimePicker();
            pickupTimePicker = new DateTimePicker();
            returnDatePicker = new DateTimePicker();
            returnTimePicker = new DateTimePicker();
            pictureBox7 = new PictureBox();
            menu = new Button();
            login = new Button();
            button7 = new Button();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            panelcategories.SuspendLayout();
            tableLayoutPanellogo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            mainpanel.SuspendLayout();
            paneltop.SuspendLayout();
            panelCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panelcategories
            // 
            panelcategories.BackColor = Color.White;
            panelcategories.Controls.Add(tableLayoutPanellogo);
            panelcategories.Controls.Add(catenaem);
            panelcategories.Controls.Add(tableLayoutPanel1);
            panelcategories.Dock = DockStyle.Top;
            panelcategories.Location = new Point(0, 693);
            panelcategories.Margin = new Padding(3, 4, 3, 4);
            panelcategories.Name = "panelcategories";
            panelcategories.Size = new Size(1614, 625);
            panelcategories.TabIndex = 3;
            // 
            // tableLayoutPanellogo
            // 
            tableLayoutPanellogo.BackColor = Color.White;
            tableLayoutPanellogo.CausesValidation = false;
            tableLayoutPanellogo.ColumnCount = 1;
            tableLayoutPanellogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.88235F));
            tableLayoutPanellogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.11765F));
            tableLayoutPanellogo.Controls.Add(ourcategoreis, 0, 0);
            tableLayoutPanellogo.Dock = DockStyle.Top;
            tableLayoutPanellogo.Location = new Point(0, 0);
            tableLayoutPanellogo.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanellogo.Name = "tableLayoutPanellogo";
            tableLayoutPanellogo.RowCount = 1;
            tableLayoutPanellogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanellogo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanellogo.Size = new Size(1614, 62);
            tableLayoutPanellogo.TabIndex = 2;
            // 
            // ourcategoreis
            // 
            ourcategoreis.Anchor = AnchorStyles.None;
            ourcategoreis.AutoSize = true;
            ourcategoreis.BackColor = Color.Transparent;
            ourcategoreis.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ourcategoreis.ForeColor = SystemColors.InfoText;
            ourcategoreis.Location = new Point(658, 8);
            ourcategoreis.Name = "ourcategoreis";
            ourcategoreis.Size = new Size(298, 46);
            ourcategoreis.TabIndex = 0;
            ourcategoreis.Text = "our categories";
            ourcategoreis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // catenaem
            // 
            catenaem.Location = new Point(0, 0);
            catenaem.Name = "catenaem";
            catenaem.Size = new Size(100, 29);
            catenaem.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.07828F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.50617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.46914F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel8, 0, 1);
            tableLayoutPanel1.Controls.Add(panel9, 1, 1);
            tableLayoutPanel1.Controls.Add(panel10, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 33);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1614, 592);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(sed);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(sedan);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 5);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 286);
            panel2.TabIndex = 0;
            // 
            // sed
            // 
            sed.AutoSize = true;
            sed.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            sed.Location = new Point(190, 32);
            sed.Name = "sed";
            sed.Size = new Size(71, 25);
            sed.TabIndex = 3;
            sed.Text = "sedan";
            // 
            // button1
            // 
            button1.Location = new Point(154, 220);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 2;
            button1.Text = "discover more";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // sedan
            // 
            sedan.Location = new Point(0, 0);
            sedan.Name = "sedan";
            sedan.Size = new Size(100, 29);
            sedan.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 75);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(537, 5);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 286);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(su);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(suv);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(549, 286);
            panel4.TabIndex = 2;
            // 
            // su
            // 
            su.AutoSize = true;
            su.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            su.Location = new Point(234, 29);
            su.Name = "su";
            su.Size = new Size(46, 25);
            su.TabIndex = 4;
            su.Text = "suv";
            // 
            // button2
            // 
            button2.Location = new Point(200, 220);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(131, 29);
            button2.TabIndex = 2;
            button2.Text = "discover more";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // suv
            // 
            suv.Location = new Point(0, 0);
            suv.Name = "suv";
            suv.Size = new Size(100, 29);
            suv.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(133, 58);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1093, 5);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(517, 286);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(luxury);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(pictureBox3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(517, 286);
            panel6.TabIndex = 0;
            // 
            // luxury
            // 
            luxury.AutoSize = true;
            luxury.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            luxury.Location = new Point(233, 29);
            luxury.Name = "luxury";
            luxury.Size = new Size(70, 25);
            luxury.TabIndex = 5;
            luxury.Text = "luxury";
            // 
            // button3
            // 
            button3.Location = new Point(203, 220);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 1;
            button3.Text = "discover more";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(159, 62);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(232, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button4);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(pictureBox4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(4, 300);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(526, 287);
            panel8.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(176, 209);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 5;
            button4.Text = "discover more";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(190, 46);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 4;
            label2.Text = "motorcycle";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(128, 75);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(231, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(button5);
            panel9.Controls.Add(label3);
            panel9.Controls.Add(pictureBox5);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(537, 300);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(549, 287);
            panel9.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(210, 209);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(121, 29);
            button5.TabIndex = 6;
            button5.Text = "discover more";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(243, 46);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 5;
            label3.Text = "electric";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(191, 81);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(189, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(button6);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(pictureBox6);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(1093, 300);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(517, 287);
            panel10.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(203, 209);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(121, 29);
            button6.TabIndex = 7;
            button6.Text = "discover more";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(222, 49);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 6;
            label4.Text = "family";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(159, 75);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(217, 136);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // mainpanel
            // 
            mainpanel.AutoScroll = true;
            mainpanel.BackColor = Color.Red;
            mainpanel.Controls.Add(panelcategories);
            mainpanel.Controls.Add(paneltop);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 96);
            mainpanel.Margin = new Padding(3, 4, 3, 4);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1635, 636);
            mainpanel.TabIndex = 3;
            // 
            // paneltop
            // 
            paneltop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paneltop.BackColor = SystemColors.ActiveBorder;
            paneltop.BackgroundImageLayout = ImageLayout.Stretch;
            paneltop.Controls.Add(panelCalendar);
            paneltop.Controls.Add(pictureBox7);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Margin = new Padding(3, 4, 3, 4);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(1614, 693);
            paneltop.TabIndex = 1;
            paneltop.Paint += paneltop_Paint_1;
            // 
            // panelCalendar
            // 
            panelCalendar.BackColor = Color.White;
            panelCalendar.BorderStyle = BorderStyle.FixedSingle;
            panelCalendar.Controls.Add(cityreturn);
            panelCalendar.Controls.Add(cityComboBox);
            panelCalendar.Controls.Add(returnDifferentCheckBox);
            panelCalendar.Controls.Add(pickupDatePicker);
            panelCalendar.Controls.Add(pickupTimePicker);
            panelCalendar.Controls.Add(returnDatePicker);
            panelCalendar.Controls.Add(returnTimePicker);
            panelCalendar.Location = new Point(0, 566);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(1614, 127);
            panelCalendar.TabIndex = 0;
            panelCalendar.Paint += panelCalendar_Paint;
            // 
            // cityreturn
            // 
            cityreturn.FormattingEnabled = true;
            cityreturn.Location = new Point(961, 26);
            cityreturn.Name = "cityreturn";
            cityreturn.Size = new Size(268, 28);
            cityreturn.TabIndex = 8;
            cityreturn.Text = "drop off location";
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(396, 26);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(271, 28);
            cityComboBox.TabIndex = 7;
            cityComboBox.Text = "pick up location";
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // returnDifferentCheckBox
            // 
            returnDifferentCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            returnDifferentCheckBox.Location = new Point(705, 31);
            returnDifferentCheckBox.Name = "returnDifferentCheckBox";
            returnDifferentCheckBox.Size = new Size(250, 30);
            returnDifferentCheckBox.TabIndex = 1;
            returnDifferentCheckBox.Text = "Return to a different location";
            returnDifferentCheckBox.CheckedChanged += ReturnDifferentCheckBox_CheckedChanged;
            // 
            // pickupDatePicker
            // 
            pickupDatePicker.Format = DateTimePickerFormat.Short;
            pickupDatePicker.Location = new Point(396, 86);
            pickupDatePicker.Name = "pickupDatePicker";
            pickupDatePicker.Size = new Size(140, 27);
            pickupDatePicker.TabIndex = 3;
            pickupDatePicker.ValueChanged += pickupDatePicker_ValueChanged;
            // 
            // pickupTimePicker
            // 
            pickupTimePicker.Format = DateTimePickerFormat.Time;
            pickupTimePicker.Location = new Point(535, 86);
            pickupTimePicker.Name = "pickupTimePicker";
            pickupTimePicker.ShowUpDown = true;
            pickupTimePicker.Size = new Size(120, 27);
            pickupTimePicker.TabIndex = 4;
            pickupTimePicker.Visible = false;
            pickupTimePicker.ValueChanged += pickupTimePicker_ValueChanged;
            // 
            // returnDatePicker
            // 
            returnDatePicker.Format = DateTimePickerFormat.Short;
            returnDatePicker.Location = new Point(961, 86);
            returnDatePicker.Name = "returnDatePicker";
            returnDatePicker.Size = new Size(140, 27);
            returnDatePicker.TabIndex = 5;
            // 
            // returnTimePicker
            // 
            returnTimePicker.Format = DateTimePickerFormat.Time;
            returnTimePicker.Location = new Point(825, 86);
            returnTimePicker.Name = "returnTimePicker";
            returnTimePicker.ShowUpDown = true;
            returnTimePicker.Size = new Size(120, 27);
            returnTimePicker.TabIndex = 6;
            returnTimePicker.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1614, 703);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
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
            menu.Location = new Point(111, 19);
            menu.Margin = new Padding(3, 6, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(157, 42);
            menu.TabIndex = 3;
            menu.Text = "Profile";
            menu.TextAlign = ContentAlignment.MiddleRight;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            menu.MouseEnter += menu_MouseEnter;
            menu.MouseLeave += menu_MouseLeave;
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
            login.Location = new Point(297, 14);
            login.Margin = new Padding(3, 6, 3, 6);
            login.Name = "login";
            login.Size = new Size(122, 53);
            login.TabIndex = 3;
            login.Text = "Log out";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            login.MouseEnter += login_MouseEnter;
            login.MouseLeave += login_MouseLeave;
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
            button7.Location = new Point(425, 15);
            button7.Margin = new Padding(3, 6, 3, 6);
            button7.Name = "button7";
            button7.Size = new Size(122, 74);
            button7.TabIndex = 6;
            button7.Text = "Contact us";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(login);
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1635, 96);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(103, 93);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1635, 732);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            panelcategories.ResumeLayout(false);
            tableLayoutPanellogo.ResumeLayout(false);
            tableLayoutPanellogo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            mainpanel.ResumeLayout(false);
            paneltop.ResumeLayout(false);
            panelCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ReturnDifferentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cityreturn.Visible = returnDifferentCheckBox.Checked;


        }





        #endregion

        private Panel paneltop;
        private Panel panelcategories;
        private TableLayoutPanel tableLayoutPanel1;
        private Label catenaem;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label sedan;
        private Button button1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button button2;
        private Label suv;
        private Panel mainpanel;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanellogo;
        private Label sed;
        private Label su;
        private Label luxury;
        private Button button3;
        private Panel panel8;
        private PictureBox pictureBox4;
        private Button button4;
        private Label label2;
        private Panel panel9;
        private Button button5;
        private Label label3;
        private PictureBox pictureBox5;
        private Panel panel10;
        private Label label4;
        private PictureBox pictureBox6;
        private Button button6;
        private Label ourcategoreis;
        private Panel panelCalendar;
        private CheckBox returnDifferentCheckBox;
        private PictureBox pictureBox7;
        private Button menu;
        private Button login;
        private Button button7;
        private Panel panel1;
        private PictureBox pictureBox8;
        private ComboBox cityComboBox;
        private ComboBox cityreturn;
        private DateTimePicker pickupTimePicker;
        private DateTimePicker returnTimePicker;
        private DateTimePicker pickupDatePicker;
        private DateTimePicker returnDatePicker;
    }
}