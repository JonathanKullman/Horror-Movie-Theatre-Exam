using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PickedMovieForm : Form
    {
        private bool firstNameValid;
        private bool lastNameValid;
        private bool phoneNumberValid;
        private bool ticketAmountValid;
        private int ticketAmountInt;

        public readonly BookingHandler bookingHandler = new();

        private Customer customer;
        private Movie Movie { get; set; }
        private Theatre Theatre { get; set; }
        private string PicturePath { get; set; }
        private string MovieName { get; set; }
        private string MovieSummary { get; set; }
        public PickedMovieForm(string movieName)
        {
            InitializeComponent();
            MovieName = movieName;
            Movie = bookingHandler.GetMovie(movieName);
            PicturePath = Movie.PathOfPicture;
            MovieSummary = Movie.Summary;
            pBoxSelectedMovie.Image = Image.FromFile(PicturePath);
            tBoxMovieSummary.Text = MovieSummary;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTicketsLeftChange.ForeColor = Color.ForestGreen;

            if (comboBox1.Text == "20:00 - 22:00" && chBoxWheelChairNO.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";


                Theatre = bookingHandler.GetTheatre(new DateTime(2020, 06, 15, 20, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }
            }
            else if (comboBox1.Text == "20:00 - 22:00" && chBoxWheelChairYes.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";


                Theatre = bookingHandler.GetTheatreForWheelChair(new DateTime(2020, 06, 15, 20, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }
            }
            else if (comboBox1.Text == "22:00 - 00:00" && chBoxWheelChairNO.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatre(new DateTime(2020, 06, 15, 22, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }

            }
            else if (comboBox1.Text == "22:00 - 00:00" && chBoxWheelChairYes.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatreForWheelChair(new DateTime(2020, 06, 15, 22, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }

            }
            else if (comboBox1.Text == "00:00 - 02:00" && chBoxWheelChairNO.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatre(new DateTime(2020, 06, 16, 00, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }
            }
            else if (comboBox1.Text == "00:00 - 02:00" && chBoxWheelChairYes.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatreForWheelChair(new DateTime(2020, 06, 16, 00, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }
            }
            else if (comboBox1.Text == "02:00 - 04:00" && chBoxWheelChairNO.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatre(new DateTime(2020, 06, 16, 02, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");

                }

            }
            else if (comboBox1.Text == "02:00 - 04:00" && chBoxWheelChairYes.Checked == true)
            {
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
                ticketAmountValid = false;
                tBoxFirstName.Text = "";
                tBoxLastName.Text = "";
                tBoxPhoneNumber.Text = "";
                cBoxChooseTicketAmount.Text = "";

                Theatre = bookingHandler.GetTheatreForWheelChair(new DateTime(2020, 06, 16, 02, 00, 00), Movie);
                if (Theatre != null && Theatre.SeatsLeft > 0)
                {
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = true;
                    lblLastName.Visible = true;
                    lblPhoneNumber.Visible = true;
                    lblTickets.Visible = true;
                    tBoxFirstName.Visible = true;
                    tBoxLastName.Visible = true;
                    btnBookNow.Visible = true;
                    tBoxPhoneNumber.Visible = true;
                    cBoxChooseTicketAmount.Visible = true;
                    lblTicketsLeftChange.Text = Theatre.SeatsLeft.ToString();
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else if (Theatre != null)
                {
                    lblTicketsLeftChange.ForeColor = Color.Red;
                    lblTheatreHallChange.Visible = true;
                    lblTicketsLeftChange.Visible = true;
                    lblTicketsLeftText.Visible = true;
                    lblTheatreHallText.Visible = true;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;                    
                    lblTicketsLeftChange.Text = "Sold Out";
                    lblTheatreHallChange.Text = Theatre.HallNumber.ToString();
                }
                else
                {
                    lblTheatreHallChange.Visible = false;
                    lblTicketsLeftChange.Visible = false;
                    lblTicketsLeftText.Visible = false;
                    lblTheatreHallText.Visible = false;
                    lblFirstName.Visible = false;
                    lblLastName.Visible = false;
                    lblPhoneNumber.Visible = false;
                    lblTickets.Visible = false;
                    tBoxFirstName.Visible = false;
                    tBoxLastName.Visible = false;
                    btnBookNow.Visible = false;
                    tBoxPhoneNumber.Visible = false;
                    cBoxChooseTicketAmount.Visible = false;

                    MessageBox.Show("There is no show of this movie at this time\nin a theatre hall that is adapted for wheelchairs.");
                }

            }

        }

        private void chBoxWheelChairYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWheelChairYes.Checked == true)
            {
                comboBox1.Visible = true;
                chBoxWheelChairNO.Checked = false;

                lblTheatreHallChange.Visible = false;
                lblTicketsLeftChange.Visible = false;
                lblTicketsLeftText.Visible = false;
                lblTheatreHallText.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblPhoneNumber.Visible = false;
                lblTickets.Visible = false;
                tBoxFirstName.Visible = false;
                tBoxLastName.Visible = false;
                btnBookNow.Visible = false;
                tBoxPhoneNumber.Visible = false;
                cBoxChooseTicketAmount.Visible = false;

                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;

            }
            else if (chBoxWheelChairNO.Checked == true)
            {
                comboBox1.Visible = true;
                chBoxWheelChairYes.Checked = false;

                lblTheatreHallChange.Visible = false;
                lblTicketsLeftChange.Visible = false;
                lblTicketsLeftText.Visible = false;
                lblTheatreHallText.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblPhoneNumber.Visible = false;
                lblTickets.Visible = false;
                tBoxFirstName.Visible = false;
                tBoxLastName.Visible = false;
                btnBookNow.Visible = false;
                tBoxPhoneNumber.Visible = false;
                cBoxChooseTicketAmount.Visible = false;

                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
            }         
        }

        private void chBoxWheelChairNO_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWheelChairNO.Checked == true)
            {
                comboBox1.Visible = true;
                chBoxWheelChairYes.Checked = false;

                lblTheatreHallChange.Visible = false;
                lblTicketsLeftChange.Visible = false;
                lblTicketsLeftText.Visible = false;
                lblTheatreHallText.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblPhoneNumber.Visible = false;
                lblTickets.Visible = false;
                tBoxFirstName.Visible = false;
                tBoxLastName.Visible = false;
                btnBookNow.Visible = false;
                tBoxPhoneNumber.Visible = false;
                cBoxChooseTicketAmount.Visible = false;

                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;

            }
            else if (chBoxWheelChairYes.Checked == true)
            {
                comboBox1.Visible = true;
                chBoxWheelChairNO.Checked = false;

                lblTheatreHallChange.Visible = false;
                lblTicketsLeftChange.Visible = false;
                lblTicketsLeftText.Visible = false;
                lblTheatreHallText.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblPhoneNumber.Visible = false;
                lblTickets.Visible = false;
                tBoxFirstName.Visible = false;
                tBoxLastName.Visible = false;
                btnBookNow.Visible = false;
                tBoxPhoneNumber.Visible = false;
                cBoxChooseTicketAmount.Visible = false;
                
                pBoxFirstNameValidCheckgif.Visible = false;
                pBoxLastNameValidCheckgif.Visible = false;
                pBoxPhoneNumberValidCheckgif.Visible = false;
                pBoxCheckboxTickets.Visible = false;
            }

        }

        private void tBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            bool fValid = bookingHandler.FirstNameValid(tBoxFirstName.Text);

            if (fValid == true)
            {
                pBoxFirstNameValidCheckgif.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxFirstNameValidCheckgif.Visible = true;
                firstNameValid = true;

            }
            else if(fValid == false)
            {
                pBoxFirstNameValidCheckgif.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxFirstNameValidCheckgif.Visible = true;
                firstNameValid = false;
            }
            if (tBoxFirstName.Text == "")
            {
                pBoxFirstNameValidCheckgif.Visible = false;
            }

            CheckIfAllTextBoxesIsValid();
        }

        private void tBoxLastName_TextChanged(object sender, EventArgs e)
        {
            bool lValid = bookingHandler.LastNameValid(tBoxLastName.Text);

            if (lValid == true)
            {
                pBoxLastNameValidCheckgif.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxLastNameValidCheckgif.Visible = true;
                lastNameValid = true;
            }
            else if(lValid == false)
            {
                pBoxLastNameValidCheckgif.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxLastNameValidCheckgif.Visible = true;
                lastNameValid = false;
            }
            if(tBoxLastName.Text == "")
            {
                pBoxLastNameValidCheckgif.Visible = false;
            }

            CheckIfAllTextBoxesIsValid();
        }

        private void tBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            bool pValid = bookingHandler.PhoneNumberValid(tBoxPhoneNumber.Text);

            if (pValid == true)
            {
                pBoxPhoneNumberValidCheckgif.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxPhoneNumberValidCheckgif.Visible = true;
                phoneNumberValid = true;
            }
            else if(pValid == false)
            {
                pBoxPhoneNumberValidCheckgif.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxPhoneNumberValidCheckgif.Visible = true;
                phoneNumberValid = false;
            }
            if(tBoxPhoneNumber.Text == "")
            {
                pBoxPhoneNumberValidCheckgif.Visible = false;
            }

            CheckIfAllTextBoxesIsValid();

        }

        private void cBoxChooseTicketAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketAmountInt = int.Parse(cBoxChooseTicketAmount.Text);

            if (ticketAmountInt > Theatre.SeatsLeft)
            {
                ticketAmountValid = false;
                pBoxCheckboxTickets.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxCheckboxTickets.Visible = true;
            }
            else if(ticketAmountInt == Theatre.SeatsLeft || ticketAmountInt < Theatre.SeatsLeft)
            {
                ticketAmountValid = true;
                pBoxCheckboxTickets.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxCheckboxTickets.Visible = true;
            }
            else
            {
                pBoxCheckboxTickets.Visible = false;
            }

            CheckIfAllTextBoxesIsValid();

            
        }
        private void CheckIfAllTextBoxesIsValid()
        {
            if (firstNameValid && lastNameValid && phoneNumberValid && ticketAmountValid)
            {
                btnBookNow.Enabled = true;
            }
            else
            {
                btnBookNow.Enabled = false;
            }
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            string tempFirstName = tBoxFirstName.Text;
            string tempLastName =  tBoxLastName.Text;
            string tempPhoneNumber = tBoxPhoneNumber.Text;
            int tempTicketAmount = ticketAmountInt;

            if (bookingHandler.CheckIfCustomerExisting(tempPhoneNumber))
            {
                MessageBox.Show($"Sorry {tempFirstName}! \n" +
                    $"There is already a booking on that phone: [{tempPhoneNumber}]. \n\n" +
                    $"You will be sent back to the movie page...");

                this.Close();
            }
            else
            {
                customer = bookingHandler.GetNewCustomer(tempFirstName, tempLastName, tempPhoneNumber, tempTicketAmount, Theatre);

                pBoxBookedApprovedGif.Visible = true;

                btnBookNow.Enabled = false;

                MessageBox.Show($"{tempFirstName}, you have successfully booked {tempTicketAmount} tickets \n" +
                    $"to the movie: {Movie.Name}. \n" +
                    $"Time of start: {Theatre.StartTime} \n" +
                    $"Theatre hall: {Theatre.HallNumber}");

                this.Close();

            }
                               
        }

    }
}
