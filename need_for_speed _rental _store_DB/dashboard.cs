using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using need_for_speed;
using Vechile_Renting_System;
using DisplayCars;
using WinFormsApp1;

namespace Vehicle_rental_store
{
    public partial class dashboard : Form
    {
        private string connectionString = "Server=localhost;Database=Vehicle_rental_store;Trusted_Connection=True;";
        public dashboard()
        {
            InitializeComponent();



        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.Font = new Font(menu.Font, FontStyle.Underline);
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Font = new Font(menu.Font, FontStyle.Regular);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            profile myProfile = new profile();


            myProfile.Show();

            this.Hide();
        }

        private void login_MouseEnter(object sender, EventArgs e)
        {
            login.Font = new Font(login.Font, FontStyle.Underline);
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.Font = new Font(login.Font, FontStyle.Regular);
        }

        private bool isMaximized = false;

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();

            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginForm logIN = new LoginForm();
            logIN.Show();

            this.Hide();
        }




        private void paneltop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void returnLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckDatabaseConnection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("✅ Database Connection Successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Connection Failed!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {

        }


        private void returnLocationTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            cityreturn.Visible = returnDifferentCheckBox.Checked;

            LoadCitiesIntoComboBox();

        }


        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 display = new Form2();
            display.Show();

            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        private void LoadCitiesIntoComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Location_name,City FROM Locations";  // Replace 'Cities' with your actual table name

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    cityComboBox.Items.Clear();

                    while (reader.Read())
                    {
                        cityComboBox.Items.Add(reader["Location_name"].ToString() + "," + reader["City"].ToString());
                        cityreturn.Items.Add(reader["Location_name"].ToString() + "," + reader["City"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading cities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateRentalDetails()
        {
            if (cityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a pickup location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (returnDifferentCheckBox.Checked && cityreturn.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a return location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime pickupDateTime = pickupDatePicker.Value.Date + pickupTimePicker.Value.TimeOfDay;
            DateTime returnDateTime = returnDatePicker.Value.Date + returnTimePicker.Value.TimeOfDay;

            if (pickupDateTime < DateTime.Now)
            {
                MessageBox.Show("Pickup date/time must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (returnDateTime <= pickupDateTime)
            {
                MessageBox.Show("Return date/time must be after pickup date/time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((returnDateTime - pickupDateTime).TotalHours < 1)
            {
                MessageBox.Show("Minimum rental duration is 1 hour.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void StoreRentalDetailsInSession(string category)
        {
            string pickupLocationInfo = cityComboBox.SelectedItem.ToString();
            string[] pickupParts = pickupLocationInfo.Split(',');
            int pickupLocationId = GetLocationId(pickupParts[0].Trim(), pickupParts[1].Trim());

            int returnLocationId = pickupLocationId;
            if (returnDifferentCheckBox.Checked && cityreturn.SelectedIndex != -1)
            {
                string returnLocationInfo = cityreturn.SelectedItem.ToString();
                string[] returnParts = returnLocationInfo.Split(',');
                returnLocationId = GetLocationId(returnParts[0].Trim(), returnParts[1].Trim());
            }

            DateTime pickupDateTime = pickupDatePicker.Value.Date + pickupTimePicker.Value.TimeOfDay;
            DateTime returnDateTime = returnDatePicker.Value.Date + returnTimePicker.Value.TimeOfDay;

            UserSession.pickupLocationID = pickupLocationId;
            UserSession.returnLocationID = returnLocationId;
            UserSession.pickupDate = pickupDateTime;
            UserSession.returnDate = returnDateTime;
            UserSession.Category = category;

        }

        private int GetLocationId(string locationName, string city)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Location_ID FROM Locations WHERE Location_name = @LocationName AND City = @City";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LocationName", locationName);
                cmd.Parameters.AddWithValue("@City", city);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        private void searchTextBox_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("Family");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("Sedan");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("SUV");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("Luxury");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("Motorcycle");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidateRentalDetails())
            {

                StoreRentalDetailsInSession("Electric");
                DisplayCar display = new DisplayCar();
                display.Show();

                this.Hide();
            }
        }

        private void pickupTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pickupDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

