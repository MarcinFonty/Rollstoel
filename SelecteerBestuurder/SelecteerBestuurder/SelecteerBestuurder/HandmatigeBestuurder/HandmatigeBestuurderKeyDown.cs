using System.Windows.Forms;

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
                    break;
            }

            //using (var client = new HttpClient())
            //{
            //    var result = await client.GetAsync(IP);

            //    switch (buttonPress.KeyCode)
            //    {
            //        case Keys.W:
            //            result = await client.GetAsync(IP + "/WON");
            //            break;
            //        case Keys.A:
            //            result = await client.GetAsync(IP + "/AON");
            //            break;
            //        case Keys.D:
            //            result = await client.GetAsync(IP + "/DON");
            //            break;
            //        case Keys.S:
            //            result = await client.GetAsync(IP + "/SON");
            //            break;
            //        case Keys.Space:
            //            result = await client.GetAsync(IP + "/SBON");
            //            break;
            //    }
            //}
        }
    }
}
