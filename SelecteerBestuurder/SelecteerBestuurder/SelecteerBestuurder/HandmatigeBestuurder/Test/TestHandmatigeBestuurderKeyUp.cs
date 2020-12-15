using System.Windows.Forms;

namespace SelecteerBestuurder
{
    class TestHandmatigeBestuurderKeyUp
    {  
        public async void stuurGeenSignaal(KeyEventArgs buttonRelease, string IP)
        {
            // Test lines without needed connection
            switch (buttonRelease.KeyCode)
            {
                case Keys.W:
                    MessageBox.Show("W uit");
                    break;
                case Keys.A:
                    MessageBox.Show("A uit");
                    break;
                case Keys.S:
                    MessageBox.Show("S uit");
                    break;
                case Keys.D:
                    MessageBox.Show("D uit");
                    break;
                case Keys.Space:
                    MessageBox.Show("Spatie uit");
                    break;
            }
        }
    }
}
