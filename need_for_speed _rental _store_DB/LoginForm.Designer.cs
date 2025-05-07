namespace Vechile_Renting_System
{
    partial class LoginForm
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
            label2 = new Label();
            label1 = new Label();
            clearBtn = new Button();
            loginBtn = new Button();
            showPassTxtBox = new CheckBox();
            passwordTxtBox = new TextBox();
            PasswordLabel = new Label();
            EmailTxtBox = new TextBox();
            UsernameLabel = new Label();
            TitleLabel = new Label();
            invalidLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(74, 78, 105);
            label2.Location = new Point(142, 420);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 23;
            label2.Text = "Create Account";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 393);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 22;
            label1.Text = "Don't have an account?";
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.ForeColor = Color.FromArgb(74, 78, 105);
            clearBtn.Location = new Point(87, 325);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(216, 35);
            clearBtn.TabIndex = 21;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(74, 78, 105);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(87, 284);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(216, 35);
            loginBtn.TabIndex = 20;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // showPassTxtBox
            // 
            showPassTxtBox.AutoSize = true;
            showPassTxtBox.Cursor = Cursors.Hand;
            showPassTxtBox.FlatStyle = FlatStyle.Flat;
            showPassTxtBox.Location = new Point(184, 246);
            showPassTxtBox.Name = "showPassTxtBox";
            showPassTxtBox.Size = new Size(151, 27);
            showPassTxtBox.TabIndex = 19;
            showPassTxtBox.Text = "Show Password";
            showPassTxtBox.UseVisualStyleBackColor = true;
            showPassTxtBox.CheckedChanged += showPassTxtBox_CheckedChanged;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.BackColor = Color.FromArgb(217, 217, 217);
            passwordTxtBox.BorderStyle = BorderStyle.None;
            passwordTxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(87, 200);
            passwordTxtBox.Multiline = true;
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(216, 28);
            passwordTxtBox.TabIndex = 16;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = Color.FromArgb(74, 78, 105);
            PasswordLabel.Location = new Point(87, 180);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(84, 23);
            PasswordLabel.TabIndex = 15;
            PasswordLabel.Text = "Password";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BackColor = Color.FromArgb(217, 217, 217);
            EmailTxtBox.BorderStyle = BorderStyle.None;
            EmailTxtBox.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxtBox.Location = new Point(87, 132);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(216, 28);
            EmailTxtBox.TabIndex = 14;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.ForeColor = Color.FromArgb(74, 78, 105);
            UsernameLabel.Location = new Point(87, 112);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(54, 23);
            UsernameLabel.TabIndex = 13;
            UsernameLabel.Text = "Email";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(34, 51, 59);
            TitleLabel.Location = new Point(87, 68);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(233, 34);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Welcome Back";
            // 
            // invalidLabel
            // 
            invalidLabel.AutoSize = true;
            invalidLabel.ForeColor = Color.Red;
            invalidLabel.Location = new Point(87, 231);
            invalidLabel.Name = "invalidLabel";
            invalidLabel.Size = new Size(250, 23);
            invalidLabel.TabIndex = 24;
            invalidLabel.Text = "Email or password is incorrect";
            invalidLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 489);
            Controls.Add(invalidLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clearBtn);
            Controls.Add(loginBtn);
            Controls.Add(showPassTxtBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailTxtBox);
            Controls.Add(UsernameLabel);
            Controls.Add(TitleLabel);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button clearBtn;
        private Button loginBtn;
        private CheckBox showPassTxtBox;
        private TextBox passwordTxtBox;
        private Label PasswordLabel;
        private TextBox EmailTxtBox;
        private Label UsernameLabel;
        private Label TitleLabel;
        private Label invalidLabel;
    }
}