using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayCars
{
    public partial class CarListingControl : UserControl
    {
        private string startDate;
        private string endDate;
        private int vehicleID;
        private float price;
        private int pickup;
        private int dropoff;
        public CarListingControl()
        {
            

            InitializeComponent();
            this.HandleCreated += (s, e) => ApplyRoundedCorners(15);

            circlePanel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(102, 0, 153)), 0, 0, 24, 24);
            };

            this.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid);
            };

            btnBookNow.Click += (sender, e) => OnBookButtonClicked();
        }

        public event EventHandler BookButtonClicked;

        public void LoadCarDetails( Image image, string name, string type, string price, int passengers, int luggage, string transmission)
        {
            pictureBoxCar.Image = image;
            lblCarName.Text = name;
            lblCarType.Text = type;
            lblPrice.Text = price;
            lblPassengers.Text = passengers.ToString();
            lblLuggage.Text = luggage.ToString();
            lblTrans.Text = transmission;
        }

        protected virtual void OnBookButtonClicked()
        {
            BookButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void ApplyRoundedCorners(int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPassengersIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblPassengers_Click(object sender, EventArgs e)
        {

        }

        private void lblTransmission_Click(object sender, EventArgs e)
        {

        }

        private void lblTrans_Click(object sender, EventArgs e)
        {

        }

        private void CarListingControl_Load(object sender, EventArgs e)
        {

        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
