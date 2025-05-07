namespace DisplayCars
{
    partial class DisplayCar
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
            lblCategory = new Label();
            lblSort = new Label();
            cmbCategories = new ComboBox();
            cmbSort = new ComboBox();
            flowLayoutCars = new FlowLayoutPanel();
            menu = new Button();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(63, 97);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(113, 19);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "By Categories";
            lblCategory.Click += label1_Click;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSort.Location = new Point(311, 97);
            lblSort.Margin = new Padding(4, 0, 4, 0);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(62, 19);
            lblSort.TabIndex = 1;
            lblSort.Text = "Sort by";
            lblSort.Click += label2_Click;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.IntegralHeight = false;
            cmbCategories.Location = new Point(67, 122);
            cmbCategories.Margin = new Padding(4, 5, 4, 5);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(200, 27);
            cmbCategories.TabIndex = 2;
            cmbCategories.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbSort
            // 
            cmbSort.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(315, 122);
            cmbSort.Margin = new Padding(4, 5, 4, 5);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(200, 27);
            cmbSort.TabIndex = 3;
            cmbSort.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // flowLayoutCars
            // 
            flowLayoutCars.AutoScroll = true;
            flowLayoutCars.FlowDirection = FlowDirection.TopDown;
            flowLayoutCars.Location = new Point(67, 252);
            flowLayoutCars.Margin = new Padding(4, 5, 4, 5);
            flowLayoutCars.Name = "flowLayoutCars";
            flowLayoutCars.Size = new Size(1280, 923);
            flowLayoutCars.TabIndex = 5;
            flowLayoutCars.WrapContents = false;
            flowLayoutCars.Paint += flowLayoutPanel1_Paint;
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
            menu.Location = new Point(30, -16);
            menu.Margin = new Padding(3, 6, 3, 4);
            menu.Name = "menu";
            menu.Size = new Size(117, 109);
            menu.TabIndex = 6;
            menu.Text = "Home";
            menu.TextAlign = ContentAlignment.MiddleRight;
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // DisplayCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 768);
            Controls.Add(menu);
            Controls.Add(flowLayoutCars);
            Controls.Add(cmbSort);
            Controls.Add(cmbCategories);
            Controls.Add(lblSort);
            Controls.Add(lblCategory);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DisplayCar";
            Padding = new Padding(27, 31, 27, 31);
            Text = "CarRentalDisplay";
            Load += DisplayCar_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblSort;
        private ComboBox cmbCategories;
        private ComboBox cmbSort;
        private FlowLayoutPanel flowLayoutCars;
        private Button menu;
    }
}

