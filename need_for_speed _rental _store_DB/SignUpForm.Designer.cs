namespace Vechile_Renting_System
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            UsernameLabel = new Label();
            UsernametxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            PasswordLabel = new Label();
            ConfirmPassTxtBox = new TextBox();
            confirmPassLabel = new Label();
            showPassCheckBox = new CheckBox();
            registerBtn = new Button();
            clearBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SSNTxtbox = new TextBox();
            label3 = new Label();
            addresstxtBox = new TextBox();
            label4 = new Label();
            invalidLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(34, 51, 59);
            TitleLabel.Location = new Point(82, 70);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(194, 34);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Get Started";
            TitleLabel.Click += label1_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.ForeColor = Color.FromArgb(74, 78, 105);
            UsernameLabel.Location = new Point(82, 120);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(54, 23);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Email";
            // 
            // UsernametxtBox
            // 
            UsernametxtBox.BackColor = Color.FromArgb(217, 217, 217);
            UsernametxtBox.BorderStyle = BorderStyle.None;
            UsernametxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UsernametxtBox.Location = new Point(82, 140);
            UsernametxtBox.Multiline = true;
            UsernametxtBox.Name = "UsernametxtBox";
            UsernametxtBox.Size = new Size(216, 28);
            UsernametxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = Color.FromArgb(217, 217, 217);
            passwordTxtBox.BorderStyle = BorderStyle.None;
            passwordTxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(82, 215);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(216, 28);
            passwordTxtBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = Color.FromArgb(74, 78, 105);
            PasswordLabel.Location = new Point(82, 195);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(84, 23);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += label1_Click_1;
            // 
            // ConfirmPassTxtBox
            // 
            ConfirmPassTxtBox.BackColor = Color.FromArgb(217, 217, 217);
            ConfirmPassTxtBox.BorderStyle = BorderStyle.None;
            ConfirmPassTxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassTxtBox.Location = new Point(82, 287);
            ConfirmPassTxtBox.Multiline = true;
            ConfirmPassTxtBox.Name = "ConfirmPassTxtBox";
            ConfirmPassTxtBox.PasswordChar = '*';
            ConfirmPassTxtBox.Size = new Size(216, 28);
            ConfirmPassTxtBox.TabIndex = 6;
            // 
            // confirmPassLabel
            // 
            confirmPassLabel.AutoSize = true;
            confirmPassLabel.ForeColor = Color.FromArgb(74, 78, 105);
            confirmPassLabel.Location = new Point(82, 267);
            confirmPassLabel.Name = "confirmPassLabel";
            confirmPassLabel.Size = new Size(155, 23);
            confirmPassLabel.TabIndex = 5;
            confirmPassLabel.Text = "Confirm Password";
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.Cursor = Cursors.Hand;
            showPassCheckBox.FlatStyle = FlatStyle.Flat;
            showPassCheckBox.Location = new Point(188, 473);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(151, 27);
            showPassCheckBox.TabIndex = 7;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.UseVisualStyleBackColor = true;
            showPassCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(74, 78, 105);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(82, 509);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(216, 35);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "REGISTER";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.ForeColor = Color.FromArgb(74, 78, 105);
            clearBtn.Location = new Point(82, 569);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(216, 35);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 622);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 10;
            label1.Text = "Already have an account?";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(74, 78, 105);
            label2.Location = new Point(165, 649);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 11;
            label2.Text = "Log-In";
            label2.Click += label2_Click;
            // 
            // SSNTxtbox
            // 
            SSNTxtbox.BackColor = Color.FromArgb(217, 217, 217);
            SSNTxtbox.BorderStyle = BorderStyle.None;
            SSNTxtbox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SSNTxtbox.Location = new Point(82, 356);
            SSNTxtbox.Multiline = true;
            SSNTxtbox.Name = "SSNTxtbox";
            SSNTxtbox.Size = new Size(216, 28);
            SSNTxtbox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(74, 78, 105);
            label3.Location = new Point(82, 336);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 12;
            label3.Text = "SSN";
            // 
            // addresstxtBox
            // 
            addresstxtBox.BackColor = Color.FromArgb(217, 217, 217);
            addresstxtBox.BorderStyle = BorderStyle.None;
            addresstxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            addresstxtBox.Location = new Point(82, 422);
            addresstxtBox.Multiline = true;
            addresstxtBox.Name = "addresstxtBox";
            addresstxtBox.Size = new Size(216, 28);
            addresstxtBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(74, 78, 105);
            label4.Location = new Point(82, 402);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 14;
            label4.Text = "Address";
            // 
            // invalidLabel
            // 
            invalidLabel.AutoSize = true;
            invalidLabel.ForeColor = Color.Red;
            invalidLabel.Location = new Point(82, 453);
            invalidLabel.Name = "invalidLabel";
            invalidLabel.Size = new Size(185, 23);
            invalidLabel.TabIndex = 16;
            invalidLabel.Text = "All fields are required";
            invalidLabel.Visible = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(400, 700);
            Controls.Add(invalidLabel);
            Controls.Add(addresstxtBox);
            Controls.Add(label4);
            Controls.Add(SSNTxtbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(registerBtn);
            Controls.Add(showPassCheckBox);
            Controls.Add(ConfirmPassTxtBox);
            Controls.Add(confirmPassLabel);
            Controls.Add(passwordTxtBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernametxtBox);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign-Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label UsernameLabel;
        private TextBox UsernametxtBox;
        private TextBox passwordTxtBox;
        private Label PasswordLabel;
        private TextBox ConfirmPassTxtBox;
        private Label confirmPassLabel;
        private CheckBox showPassCheckBox;
        private Button registerBtn;
        private Button clearBtn;
        private Label label1;
        private Label label2;
        private TextBox SSNTxtbox;
        private Label label3;
        private TextBox addresstxtBox;
        private Label label4;
        private Label invalidLabel;
    }
}
