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
        public async void stuurSignaal(KeyEventArgs buttonPress, string IP)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(IP);

                switch (buttonPress.KeyCode)
                {
                    case Keys.W:
                        result = await client.GetAsync(IP + "/WON");
                        break;
                    case Keys.A:
                        result = await client.GetAsync(IP + "/AON");
                        break;
                    case Keys.D:
                        result = await client.GetAsync(IP + "/DON");
                        break;
                    case Keys.S:
                        result = await client.GetAsync(IP + "/SON");
                        break;
                    case Keys.Space:
                        result = await client.GetAsync(IP + "/SBON");
                        break;
                }
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
