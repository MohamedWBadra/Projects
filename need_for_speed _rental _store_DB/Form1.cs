using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using Vehicle_rental_store;

namespace DisplayCars
{
    public partial class DisplayCar : Form
    {
        private string Category = UserSession.Category;
        private DateTime start = UserSession.pickupDate;
        private DateTime end = UserSession.returnDate;
        private int pickup = UserSession.pickupLocationID;
        private int dropoff = UserSession.returnLocationID;
        public string connectionString = "Data Source=(local);Initial Catalog=Vehicle_rental_store;Integrated Security=SSPI;MultipleActiveResultSets=True";


        public DisplayCar()
        {
            InitializeComponent();

        }
        private void DisplayCar_load(object sender, EventArgs e)
        {
            PopulateFilterDropdowns();
            LoadVehiclesFromDatabase();

            cmbCategories.SelectedIndexChanged += (s, args) => LoadVehiclesFromDatabase();
            cmbSort.SelectedIndexChanged += (s, args) => LoadVehiclesFromDatabase();
        }
        private void PopulateFilterDropdowns()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Category_name FROM Vehicle_Category ORDER BY Category_name";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    cmbCategories.Items.Add("Select a category:");

                    while (reader.Read())
                    {
                        string categoryName = reader["Category_name"].ToString();
                        if (!string.IsNullOrEmpty(categoryName))
                        {
                            cmbCategories.Items.Add(categoryName);
                        }
                    }

                    reader.Close();
                }
            }
            catch
            {
                cmbCategories.Items.Add("Select a category:");
                cmbCategories.Items.Add("Compact");
                cmbCategories.Items.Add("SUV");
                cmbCategories.Items.Add("Sedan");
            }

            cmbCategories.SelectedItem = Category;

            cmbSort.Items.Add("Price Low to High");
            cmbSort.Items.Add("Price High to Low");
            cmbSort.Items.Add("Name A-Z");
            cmbSort.Items.Add("Name Z-A");
            cmbSort.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadVehiclesFromDatabase()
        {
            flowLayoutCars.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT v.Vehicle_ID, 
                                  v.Brand + ' ' + v.Model AS name, 
                                  vc.Category_name AS category,
                                  v.price_per_day, 
                                  vc.number_of_people AS passengers, 
                                  vc.Luggage AS luggage,
                                  v.Vehicle_type AS transmission_type, 
                                  v.carImage
                           FROM Vehicle v
                           INNER JOIN Vehicle_Category vc ON v.cat_id = vc.Category_ID";

                    if (cmbCategories.SelectedIndex > 0)
                    {
                        query += " WHERE vc.Category_name = @categoryName";
                    }

                    if (cmbSort.SelectedIndex >= 0)
                    {
                        switch (cmbSort.SelectedItem.ToString())
                        {
                            case "Price Low to High":
                                query += " ORDER BY v.price_per_day ASC";
                                break;
                            case "Price High to Low":
                                query += " ORDER BY v.price_per_day DESC";
                                break;
                            case "Name A-Z":
                                query += " ORDER BY name ASC";
                                break;
                            case "Name Z-A":
                                query += " ORDER BY name DESC";
                                break;
                        }
                    }

                    SqlCommand command = new SqlCommand(query, connection);

                    if (cmbCategories.SelectedIndex > 0)
                    {
                        command.Parameters.AddWithValue("@categoryName", cmbCategories.SelectedItem.ToString());
                    }


                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int vehicleId = Convert.ToInt32(reader["Vehicle_ID"]);

                        SqlCommand cmd = new SqlCommand("carAvailable2", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@startDate", start));
                        cmd.Parameters.Add(new SqlParameter("@endDate", end));
                        cmd.Parameters.Add(new SqlParameter("@vehicleID", vehicleId));
                        SqlParameter available = cmd.Parameters.Add(new SqlParameter("@available", SqlDbType.Int));
                        available.Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        string name = reader["name"].ToString();
                        string category = reader["category"].ToString();
                        decimal pricePerDay = Convert.ToDecimal(reader["price_per_day"]);
                        string price = pricePerDay.ToString("F2") + " EGP";
                        int passengers = Convert.ToInt32(reader["passengers"]);
                        int luggage = Convert.ToInt32(reader["luggage"]);
                        string transmission = reader["transmission_type"].ToString();

                        Image carImage = null;

                        if ((int)available.Value == 1) continue;
                        if (reader["carImage"] != DBNull.Value && !string.IsNullOrEmpty(reader["carImage"].ToString()))
                        {
                            try
                            {
                                using (WebClient webClient = new WebClient())
                                {
                                    byte[] imageBytes = webClient.DownloadData(reader["carImage"].ToString());
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        carImage = Image.FromStream(ms);
                                    }
                                }
                            }
                            catch
                            {
                                carImage = null;
                            }
                        }


                        if (carImage == null)
                        {
                            carImage = CreatePlaceholderImage(name);
                        }


                        CarListingControl carListing = new CarListingControl();
                        carListing.LoadCarDetails(carImage, name, category, price, passengers, luggage, transmission);
                        carListing.BookButtonClicked += (s, e) =>
                        {
                            this.Hide();
                            UserSession.pickupDate = start.Date;
                            UserSession.returnDate = end.Date;
                            UserSession.vechileID = vehicleId;
                            UserSession.price = (float)pricePerDay;
                            UserSession.pickupLocationID = pickup;
                            UserSession.returnLocationID = dropoff;
                            Checkout bigMo = new Checkout();
                            bigMo.Show();
                            bigMo.FormClosed += (sender, args) =>
                            {
                                LoadVehiclesFromDatabase();
                                this.Show();
                            };
                        };
                        carListing.Margin = new Padding(0, 0, 0, 20);
                        flowLayoutCars.Controls.Add(carListing);
                    }

                    reader.Close();

                    if (flowLayoutCars.Controls.Count == 0)
                    {
                        Label noResultsLabel = new Label();
                        noResultsLabel.Text = "No vehicles found matching the selected criteria.";
                        noResultsLabel.AutoSize = true;
                        noResultsLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                        noResultsLabel.ForeColor = Color.DarkGray;
                        noResultsLabel.Padding = new Padding(20);
                        flowLayoutCars.Controls.Add(noResultsLabel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Label errorLabel = new Label();
                    errorLabel.Text = "Unable to load vehicle data. Please check your database connection.";
                    errorLabel.AutoSize = true;
                    errorLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Padding = new Padding(20);
                    flowLayoutCars.Controls.Add(errorLabel);
                }
            }
        }

        private Image CreatePlaceholderImage(string vehicleName)
        {
            Bitmap placeholder = new Bitmap(250, 180);
            using (Graphics g = Graphics.FromImage(placeholder))
            {
                g.Clear(Color.LightGray);

                using (Font nameFont = new Font("Arial", 12, FontStyle.Bold))
                {
                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    Rectangle textRect = new Rectangle(0, placeholder.Height / 2 - 30, placeholder.Width, 30);
                    g.DrawString(vehicleName, nameFont, Brushes.Black, textRect, format);
                }

                using (Font noImageFont = new Font("Arial", 10))
                {
                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    Rectangle textRect = new Rectangle(0, placeholder.Height / 2 + 10, placeholder.Width, 20);
                    g.DrawString("No Image Available", noImageFont, Brushes.DarkGray, textRect, format);
                }

                using (Pen borderPen = new Pen(Color.DarkGray, 1))
                {
                    g.DrawRectangle(borderPen, 0, 0, placeholder.Width - 1, placeholder.Height - 1);
                }
            }
            return placeholder;
        }

        private void DisplayBookingInfo(int vehicleId, string vehicleName)
        {
            MessageBox.Show($"Selected vehicle: {vehicleName} (ID: {vehicleId})\n\n" +
                           "To complete booking, please contact our customer service.",
                           "Vehicle Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            dashboard home = new dashboard();
            home.Show();

            this.Hide();
        }
    }
}