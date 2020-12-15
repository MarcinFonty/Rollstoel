using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormHandmatigeBestuurder : Form
    {
        // sets up the fields
        private bool IsKeyDown = false;
        private string IP;
        private int POORT;

        // creates new instance
        FormSelecteerBestuurder getIpAndPort = new FormSelecteerBestuurder();
        HandmatigeBestuurderKeyDown keyDown = new HandmatigeBestuurderKeyDown();
        TestHandmatigeBestuurderKeyDown testKeyDown = new TestHandmatigeBestuurderKeyDown();

        public FormHandmatigeBestuurder()
        {
            InitializeComponent();
            this.IP = getIpAndPort.ip;
            this.POORT = getIpAndPort.poort;
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
                keyDown.stuurSignaal(e);
            }
            else
            {
                testKeyDown.stuurSignaal(e);
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
                keyDown.stuurGeenSignaal(e);
            }
            else
            {
                testKeyDown.stuurGeenSignaal(e); 
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
