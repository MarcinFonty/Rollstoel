using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormSelecteerBestuurder : Form
    {

        public FormSelecteerBestuurder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes to the manual control form so the car can be controlled manually
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHandmatig_Click(object sender, EventArgs e)
        {
            FormHandmatigeBestuurder form = new FormHandmatigeBestuurder();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Goes to the autonomous control form so the car can be controlled autonomously
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutonoom_Click(object sender, EventArgs e)
        {
            FormAutonomeBestuurder form = new FormAutonomeBestuurder();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
