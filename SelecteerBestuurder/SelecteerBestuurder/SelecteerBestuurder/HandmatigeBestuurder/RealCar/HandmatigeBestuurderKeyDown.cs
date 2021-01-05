using System.Windows.Forms;
using System.Net.Http;

namespace SelecteerBestuurder
{
    class HandmatigeBestuurderKeyDown
    {
        UDP UDP = new UDP();

        //private int i = 0;

        /// <summary>
        /// Sends the commands to the server (ESP8266) and executes them
        /// </summary>
        /// <param name="buttonPress"></param>
        /// <param name="IP"></param>
        public void rijdenAuto(KeyEventArgs buttonPress)
        {
            switch (buttonPress.KeyCode)
            {
                case Keys.W:
                    UDP.SendUDP("W");
                    break;
                case Keys.A:
                    UDP.SendUDP("A");
                    break;
                case Keys.S:
                    UDP.SendUDP("S");
                    break;
                case Keys.D:
                    UDP.SendUDP("D");
                    break;
                /*case Keys.Space:
                    UDP.SendUDP("O");
                    opslaanCoördinaten();
                    break;*/
                default:
                    break;
            }
        }

        public void stopAuto(KeyEventArgs buttonRelease)
        {
            UDP.SendUDP("B");
        }

        public void opslaanCoördinaten()
        {
            //Coördinaten coördinaten = new Coördinaten();
            //coördinaten.Xarray[i] = auto.Xgegevens();
            //coördinaten.Yarray[i] = auto.Ygegevens();
            //i++;
        }
    }
}
