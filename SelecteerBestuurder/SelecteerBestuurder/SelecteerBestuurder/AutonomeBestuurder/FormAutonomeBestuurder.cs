using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormAutonomeBestuurder : Form
    {
        // sets up the fields
        private int aantalRoutes = 5;
        private string IP;
        
        // Creates new instance of the main form so i can use get to transport the IP
        FormSelecteerBestuurder getIP = new FormSelecteerBestuurder();

        public FormAutonomeBestuurder()
        {
            InitializeComponent();
            addToComboBox();
            this.IP = getIP.ip;
        }

        /// <summary>
        /// Uses the selected route to run and follow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartRoute_Click(object sender, EventArgs e)
        {
            selectRoute();
        }

        /// <summary>
        /// Returns to the main form when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormSelecteerBestuurder form = new FormSelecteerBestuurder();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Input the different routes to the combobox
        /// </summary>
        private void addToComboBox()
        {
            for (int i = 0; i < this.aantalRoutes; i++)
            {
                this.cbSelecteerRoute.Items.Add("Oega boega");
            }
        }

        /// <summary>
        /// Takes selected route and the data belonging to it in order to follow it
        /// </summary>
        private void selectRoute()
        {
            int selectedIndex = cbSelecteerRoute.SelectedIndex;
            Object selectedItem = cbSelecteerRoute.SelectedItem;

            MessageBox.Show(selectedItem.ToString());
            MessageBox.Show(selectedIndex.ToString());
            MessageBox.Show(IP);
        }
    }
}
