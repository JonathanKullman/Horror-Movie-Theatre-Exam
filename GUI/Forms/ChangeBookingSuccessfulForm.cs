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
    public partial class ChangeBookingSuccessfulForm : Form
    {
        private BookingHandler bookingHandler = new BookingHandler();
        private Customer customer;
        private Movie movie;
        private Theatre theatre;
        public ChangeBookingSuccessfulForm()
        {
            InitializeComponent();
        }

        private void ChangeBookingSuccessfulForm_Load(object sender, EventArgs e)
        {
            customer = ChangeBookingForm.customer;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int newTicketAmount = int.Parse(cBoxChooseAmtTickets.Text);

            bookingHandler.ChangeCustomerTicketAmount(theatre, customer, newTicketAmount);

            MessageBox.Show($"You have Successfully rebooked your ticket amount! \n" +
                            $"New ticket amount: {newTicketAmount}");

            OpenChildForm(new ChangeBookingForm());


        }

        private void cBoxChooseAmtTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ticketAmountInt = int.Parse(cBoxChooseAmtTickets.Text);

            if ((ticketAmountInt <= theatre.SeatsLeft + customer.Tickets.Count()) && ticketAmountInt != customer.Tickets.Count())
            {
                btnReBook.Enabled = true;
                
                pBoxAllowedAmtTicketsChange.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxAllowedAmtTicketsChange.Visible = true;
            }
            else if (cBoxChooseAmtTickets.Text == "")
            {
                btnReBook.Enabled = false;
                pBoxAllowedAmtTicketsChange.Visible = false;
            }
            else
            {
                btnReBook.Enabled = false;

                pBoxAllowedAmtTicketsChange.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxAllowedAmtTicketsChange.Visible = true;
            }
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
