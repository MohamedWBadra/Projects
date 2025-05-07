using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using need_for_speed;
using Vehicle_rental_store;

namespace Vechile_Renting_System
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            EmailTxtBox.Clear();
            passwordTxtBox.Clear();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmailTxtBox.Text.Length == 0 || passwordTxtBox.Text.Length == 0)
            {
                invalidLabel.Text = "Email or password cannot be empty";
                invalidLabel.Visible = true;
                return;
            }
            invalidLabel.Visible = false;
            invalidLabel.Text = "Email or password are incorrect";
            invalidLabel.ForeColor = Color.Red;
            string connectionString = "Server=localhost;Database=Vehicle_rental_store;Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("validateLoginid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", EmailTxtBox.Text));
                cmd.Parameters.Add(new SqlParameter("@password", passwordTxtBox.Text));
                SqlParameter myParam = cmd.Parameters.Add("@found", SqlDbType.Int);
                myParam.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int ValidBit = (int)cmd.Parameters["@found"].Value;
                if (ValidBit == 0)
                {
                    invalidLabel.Visible = true;
                    return;
                }
                else
                {
                    UserSession.CustomerId = ValidBit;
                    dashboard home = new dashboard();
                    home.Show();

                    this.Hide();

                }

            }
            catch (Exception exception)
            {
                invalidLabel.Visible = true;
                return;

            }
            finally
            {
                con.Close();
            }

        }

        private void showPassTxtBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassTxtBox.Checked)
                passwordTxtBox.PasswordChar = '\0';
            else
            {
                passwordTxtBox.PasswordChar = '*';

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();

            this.Hide();
        }
    }
}
