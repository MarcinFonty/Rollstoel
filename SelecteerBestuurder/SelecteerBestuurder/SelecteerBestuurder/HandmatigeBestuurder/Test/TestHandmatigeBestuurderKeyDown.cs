using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    class TestHandmatigeBestuurderKeyDown
    {
        /// <summary>
        /// Sends the commands to the server (ESP8266) and executes them
        /// </summary>
        /// <param name="buttonPress"></param>
        /// <param name="IP"></param>
        public async void stuurSignaal(KeyEventArgs buttonPress, string IP)
        {
            // Test lines without needed connection
            switch (buttonPress.KeyCode)
            {
                case Keys.W:
                    MessageBox.Show("W aan");
                    MessageBox.Show(IP);
                    break;
                case Keys.A:
                    MessageBox.Show("A aan");
                    break;
                case Keys.S:
                    MessageBox.Show("S aan");
                    break;
                case Keys.D:
                    MessageBox.Show("D aan");
                    break;
                case Keys.Space:
                    MessageBox.Show("Spatie aan");
                    opslaanCoördinaten();
                    break;
            }
        }

        public void opslaanCoördinaten()
        {
            // Coördinaten coördinaten = new Coördinaten();
            // coördinaten.Xarray[i] = auto.Xgegevens();
            // coördinaten.Yarray[i] = auto.Ygegevens();
            // i++;
        }
    }
}
