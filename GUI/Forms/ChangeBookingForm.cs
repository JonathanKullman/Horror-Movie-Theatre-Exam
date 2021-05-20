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
    public partial class ChangeBookingForm : Form
    {
        private readonly BookingHandler bookingHandler = new();
        public static Customer customer;
        public ChangeBookingForm()
        {
            InitializeComponent();
        }

        private void ChangeBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchHittingEnterOrButtonClick();
        }

        private void tBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            lblNotFoundPhoneNumber.Visible = false;

            bool pValid = bookingHandler.PhoneNumberValid(tBoxSearchBar.Text);

            if (pValid == true)
            {
                pBoxSearchPNumberValidOrNot.Image = Image.FromFile("CheckmarkIcon.png");
                pBoxSearchPNumberValidOrNot.Visible = true;
            }
            else if (pValid == false)
            {
                pBoxSearchPNumberValidOrNot.Image = Image.FromFile("CrossmarkIcon.png");
                pBoxSearchPNumberValidOrNot.Visible = true;
            }
            if (tBoxSearchBar.Text == "")
            {
                pBoxSearchPNumberValidOrNot.Visible = false;
            }

        }

        private void tBoxSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchHittingEnterOrButtonClick();
            }
        }

        private void SearchHittingEnterOrButtonClick()
        {
            if (bookingHandler.CheckIfCustomerExisting(tBoxSearchBar.Text))
            {
                customer = bookingHandler.GetExistingCustomer(tBoxSearchBar.Text);

                tBoxSearchBar.Text = "";

                OpenChildForm(new ChangeBookingSuccessfulForm());

           
            }

            else
            {
                lblNotFoundPhoneNumber.Visible = true;
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
            panelFilledBackground.Controls.Add(childForm);
            panelFilledBackground.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


    }
}
