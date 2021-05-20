using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerRemovedForm : Form
    {
        BookingHandler bookingHandler = new BookingHandler();
        private Customer customer;
        private Movie movie;
        private Theatre theatre;
        public CustomerRemovedForm()
        {
            InitializeComponent();
        }


        private void CustomerRemovedForm_Load(object sender, EventArgs e)
        {
            customer = CancelBookingForm.customer;
            movie = bookingHandler.GetMovieInfo(customer);
            theatre = bookingHandler.GetTheatreInfo(customer);

            pBoxCurrentMovie.Image = Image.FromFile(movie.PathOfPicture);

            lblFNametxt.Text = customer.FirstName;
            lblLNametxt.Text = customer.LastName;
            lblMovietxt.Text = movie.Name;
            lblTicketsOwnedtxt.Text = customer.Tickets.Count.ToString();
            lblHallNumbertxt.Text = theatre.HallNumber.ToString();
            lblTicketsLefttxt.Text = theatre.SeatsLeft.ToString();
            lblPlusUrOwnTickets.Text = $"Plus your own [{customer.Tickets.Count}]\n" +
                                       $"        tickets";
        }

        private void btnCancelBooking_CLick(object sender, EventArgs e)
        {
            bookingHandler.RemoveCustomer(CancelBookingForm.customer);

            MessageBox.Show($"Your booking has been canceled!");

            OpenChildForm(new CancelBookingForm());

        }


        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChangeBookingSucFilled.Controls.Add(childForm);
            panelChangeBookingSucFilled.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}
