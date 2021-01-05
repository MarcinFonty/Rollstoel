using System;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public partial class FormTestCar : Form
    {
        // sets up the fields
        private bool IsKeyDown = false;

        // creates new instance
        TestHandmatigeBestuurderKeyDown testKeyDown = new TestHandmatigeBestuurderKeyDown();

        public FormTestCar()
        {
            InitializeComponent();
        }

        private void FormTestCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsKeyDown)
            {
                return;
            }
            IsKeyDown = true;

            testKeyDown.rijdenTestAuto(e);
        }

        private void FormTestCar_KeyUp(object sender, KeyEventArgs e)
        {
            IsKeyDown = false;

            testKeyDown.stopTestAuto(e);
        }

        private void btnTerugRealCar_Click_1(object sender, EventArgs e)
        {
            FormHandmatigeBestuurder form = new FormHandmatigeBestuurder();
            form.Show();
            this.Hide();
        }
    }
}
