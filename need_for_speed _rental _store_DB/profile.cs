using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Vehicle_rental_store;
using Vechile_Renting_System;
using System.Collections;
using WinFormsApp1;

namespace need_for_speed
{
    public partial class profile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Vehicle_rental_store;Integrated Security=SSPI");
        public profile()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void LoadCustomerOrders()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = @"SELECT 
                        b.Booking_ID,
                        v.Brand + ' ' + v.Model AS Vehicle,
                        FORMAT(b.startDate, 'MM/dd/yyyy') + ' to ' + FORMAT(b.endDate, 'MM/dd/yyyy') AS Dates,
                        bl.Total_amount AS Price,
                        bl.Bill_status AS Status
                        FROM Booking b
                        INNER JOIN Vehicle v ON b.vehicle_id = v.Vehicle_ID
                        INNER JOIN Bills bl ON b.Booking_ID = bl.booking_id
                        WHERE b.customer_id = @CustomerID
                        ORDER BY b.startDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", UserSession.CustomerId); // Using parameterized query


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dataGridViewOrders.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridViewOrders.Rows.Add(
                            reader["Booking_ID"],
                            reader["Vehicle"],
                            reader["Dates"],
                            string.Format("{0:C}", reader["Price"]),

                            reader["Status"]

                        );
                    }
                }


                // Improve grid appearance
                dataGridViewOrders.Refresh();

                dataGridViewOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridViewOrders.ClearSelection();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}\nPlease contact support.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCustomerOrders();

            dataGridViewOrders.ClearSelection();

            // Add hover effect
            dataGridViewOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            dataGridViewOrders.DefaultCellStyle.SelectionForeColor = Color.Black;
            try
            {
                con.Open();

                string query = "SELECT SSN, Customer_address, Email, Customer_Password FROM Customer WHERE Customer_ID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", UserSession.CustomerId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxSSN.Text = reader["SSN"].ToString();
                        textBoxAddress.Text = reader["Customer_address"].ToString();
                        textBoxPassword.Text = reader["Customer_Password"].ToString();
                        textBoxUsername.Text = reader["Email"].ToString();
                    }

                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void labelBrand_Click(object sender, EventArgs e)
        {

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void navBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxSSN.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("All fields are required!", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(textBoxSSN.Text, @"^\d{9}$"))
            {
                MessageBox.Show("SSN must have 9 digits", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSSN.Focus();
                return false;
            }

            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return false;
            }


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("validateEmail1", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@email", textBoxUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@id", UserSession.CustomerId));

                SqlParameter myParam = cmd.Parameters.Add(new SqlParameter("@found", System.Data.SqlDbType.Int));
                myParam.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                if ((int)myParam.Value != 0)
                {
                    MessageBox.Show("Email is already used ", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                    return false;

                }


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return true;
        }



        private void update_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
            {
                con.Open();

                string updateQuery = @"UPDATE Customer SET 
                                    SSN = @SSN, 
                                    Customer_address = @Address, 
                                    Email = @Email, 
                                    Customer_Password = @Password 
                                    WHERE Customer_ID = @CustomerID";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@CustomerID", UserSession.CustomerId);

                cmd.Parameters.AddWithValue("@SSN", textBoxSSN.Text);
                cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer data updated successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No customer found with ID=1 to update", "Warning",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            dashboard home = new dashboard();
            home.Show();

            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 display = new Form2();
            display.Show();

            this.Hide();
        }


        private void login_Click(object sender, EventArgs e)
        {
            LoginForm logIN = new LoginForm();
            logIN.Show();

            this.Hide();
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();

            this.Hide();
        }
    }

}