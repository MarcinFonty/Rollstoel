using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormHandmatigeBestuurder : Form
    {
        // sets up the fields
        private bool IsKeyDown = false;

        // creates new instance
 
        HandmatigeBestuurderKeyDown keyDown = new HandmatigeBestuurderKeyDown();
        TestHandmatigeBestuurderKeyDown testKeyDown = new TestHandmatigeBestuurderKeyDown();

        public FormHandmatigeBestuurder()
        {
            InitializeComponent();
        }   

        /// <summary>
        /// Reads when the button is pressed and executes the driving code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandmatigeBestuurder_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyDown)
            {
                return;
            }
            IsKeyDown = true;

            if (cbRealCar.Checked)
            {
                testKeyDown.stuurSignaal(e);
            }
            else
            {
                keyDown.stuurSignaal(e);
            }
        }

        /// <summary>
        /// Reads when the button is released and stops executing the driving code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandmatigeBestuurder_KeyUp(object sender, KeyEventArgs e)
        {
            IsKeyDown = false;

            if (cbRealCar.Checked) 
            {
                testKeyDown.stuurGeenSignaal(e);
            }
            else
            {
                keyDown.stuurGeenSignaal(e);
            }
        }

        /// <summary>
        /// Saves the coördinates to the struckt and goes back to the driver selection menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerug_Click(object sender, EventArgs e)
        {
            FormSelecteerBestuurder form = new FormSelecteerBestuurder();
            form.Show();
            this.Hide();
        }
    }
}
