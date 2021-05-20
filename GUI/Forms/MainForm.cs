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
    public partial class MainForm : Form
    {
        private readonly HorrorTheatreContext context = new HorrorTheatreContext();
        private readonly BookingHandler bookingHandler = new BookingHandler();
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Side Menu Visability 
        private void CustomizeDesign()
        {
            panelChangeBookingSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelChangeBookingSubMenu.Visible == true)
            {
                panelChangeBookingSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Menu Buttons
        private void btnMovies_Click(object sender, EventArgs e)
        {
            //Kod för att boka och välja film
            OpenChildForm(new PickAMovieForm());
            HideSubMenu();
        }
        private void btnChangeBooking_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelChangeBookingSubMenu);
        }
        #endregion

        #region Change Booking SubMenu
        private void btnChange_Click(object sender, EventArgs e)
        {
            //Kod för att ändra bokning
            OpenChildForm(new ChangeBookingForm());
            HideSubMenu();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Kod för att avboka bokning
            OpenChildForm(new CancelBookingForm());
            HideSubMenu();
        }

        #endregion

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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }
    }
}
