using System.Windows.Forms;
using System.Net.Http;

namespace SelecteerBestuurder
{
    class HandmatigeBestuurderKeyUp
    {
        /// <summary>
        /// Sends the commands to the server and executes them
        /// </summary>
        /// <param name="buttonRelease"></param>
        /// <param name="IP"></param>
        public async void stuurGeenSignaal(KeyEventArgs buttonRelease, string IP)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(IP);
                
                switch (buttonRelease.KeyCode)
                {
                    case Keys.W:
                        result = await client.GetAsync(IP + "/WOFF");
                        break;
                    case Keys.A:
                        result = await client.GetAsync(IP + "/AOFF");
                        break;
                    case Keys.D:
                        result = await client.GetAsync(IP + "/DOFF");
                        break;
                    case Keys.S:
                        result = await client.GetAsync(IP + "/SOFF");
                        break;
                    case Keys.Space:
                        result = await client.GetAsync(IP + "/SBOFF");
                        break;
                }
            }
        }
    }
}
