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
    public partial class PickAMovieForm : Form
    {
        public PickAMovieForm()
        {
            InitializeComponent();
        }

        #region MoviePosterClicks

        private Form activeForm = null;

        private void OpenSelectedMovieForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPickedMovieChildForm.Controls.Add(childForm);
            panelPickedMovieChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnAlien_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("Alien"));
        }
 

        private void btnAQuietPlace_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("A Quiet Place"));
        }

        private void btnIt_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("It"));
        }

        private void btnDawnOfTheDead_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("Dawn of the Dead"));
        }

        private void btnParanormalActivity_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("Paranormal Activity"));
        }

        private void btnSaw_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("Saw"));
        }

        private void btnScream_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("Scream"));
        }

        private void btnTheBlairWitchProject_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("The Blair Witch Project"));
        }

        private void btnTheGrudge_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("The Grudge"));
        }

        private void btnTheShining_Click(object sender, EventArgs e)
        {
            OpenSelectedMovieForm(new PickedMovieForm("The Shining"));
        }

        #endregion


    }
}
