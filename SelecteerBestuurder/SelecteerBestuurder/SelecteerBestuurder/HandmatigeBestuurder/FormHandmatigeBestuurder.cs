using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormHandmatigeBestuurder : Form
    {
        // sets up the fields
        private bool IsKeyDown = false;
        private string IP;

        // creates new instance so i can get the ip
        FormSelecteerBestuurder getIP = new FormSelecteerBestuurder();

        public FormHandmatigeBestuurder()
        {
            InitializeComponent();
            this.IP = getIP.ip;
        }   

        /// <summary>
        /// Reads when the button is pressed and executes the driving code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HandmatigeBestuurder_KeyDown(object sender, KeyEventArgs e)
        {
            HandmatigeBestuurderKeyDown keyDown = new HandmatigeBestuurderKeyDown();
            TestHandmatigeBestuurderKeyDown testKeyDown = new TestHandmatigeBestuurderKeyDown();

            if (IsKeyDown)
            {
                return;
            }
            IsKeyDown = true;

            if (cbRealCar.Checked)
            {
                keyDown.stuurSignaal(e, IP);
            }
            else
            {
                testKeyDown.stuurSignaal(e, IP);
            }
        }

        /// <summary>
        /// Reads when the button is released and stops executing the driving code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HandmatigeBestuurder_KeyUp(object sender, KeyEventArgs e)
        {
            HandmatigeBestuurderKeyUp keyUp = new HandmatigeBestuurderKeyUp();
            TestHandmatigeBestuurderKeyUp testKeyUp = new TestHandmatigeBestuurderKeyUp();
           
            IsKeyDown = false;

            if (cbRealCar.Checked) 
            {
                keyUp.stuurGeenSignaal(e, IP);
            }
            else
            {
                testKeyUp.stuurGeenSignaal(e, IP); 
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
