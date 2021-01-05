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

            if (cbTestCar.Checked)
            {
                laadTestForm();
            }
            else
            {
                keyDown.rijdenAuto(e);
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

            if (cbTestCar.Checked) 
            {
                laadTestForm();
            }
            else
            {
                keyDown.stopAuto(e);
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

        /// <summary>
        /// Laad nieuwe form in voor testauto
        /// </summary>
        private void laadTestForm()
        {
            FormTestCar form = new FormTestCar();
            form.Show();
            this.Hide();
        }
    }
}
