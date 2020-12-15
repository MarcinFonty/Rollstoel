using System.Windows.Forms;
using System.Net.Http;

namespace SelecteerBestuurder
{
    class HandmatigeBestuurderKeyDown
    {
        /// <summary>
        /// Sends the commands to the server (ESP8266) and executes them
        /// </summary>
        /// <param name="buttonPress"></param>
        /// <param name="IP"></param>
        public void stuurSignaal(KeyEventArgs buttonPress)
        {
            switch (buttonPress.KeyCode)
            {
                case Keys.W:
                    //SendUDP("W");
                    break;
                case Keys.A:
                    //SendUDP("A");
                    break;
                case Keys.S:
                    //SendUDP("S");
                    break;
                case Keys.D:
                    //SendUDP("D");
                    break;
                case Keys.Space:
                    //SendUDP(" ");
                    break;
            }
        }

        public void stuurGeenSignaal(KeyEventArgs buttonRelease)
        {
            //SendUDP("P");
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
