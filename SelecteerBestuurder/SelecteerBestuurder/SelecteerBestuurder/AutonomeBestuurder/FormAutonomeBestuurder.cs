using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormAutonomeBestuurder : Form
    {
        // sets up the fields
        private int aantalRoutes = 1;

        public FormAutonomeBestuurder()
        {
            InitializeComponent();
            addToComboBox();
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
            // for loop voor de hoeveelheid roetes
                this.cbSelecteerRoute.Items.Add("Test route");
        }

        /// <summary>
        /// Takes selected route and the data belonging to it in order to follow it
        /// </summary>
        private void selectRoute()
        {
            //int selectedIndex = cbSelecteerRoute.SelectedIndex;
            Object selectedItem = cbSelecteerRoute.SelectedItem;

            MessageBox.Show(selectedItem.ToString());
            //MessageBox.Show(selectedIndex.ToString());

            AutonomeBestuurder Jerry = new AutonomeBestuurder();
            Jerry.RouteRijden();

        }
    }
}
