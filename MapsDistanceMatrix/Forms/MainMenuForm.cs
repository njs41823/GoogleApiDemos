using System;
using System.Windows.Forms;

namespace MapsDistanceMatrix.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ApiDemoButton_Click(object sender, EventArgs e)
        {
            using (ApiDemoForm apiDemoForm = new ApiDemoForm())
            {
                apiDemoForm.ShowDialog();
            }
        }

        private void ShippingDataDemoButton_Click(object sender, EventArgs e)
        {
            using (ShippingDataDemoForm shippingDataDemoForm = new ShippingDataDemoForm())
            {
                shippingDataDemoForm.ShowDialog();
            }
        }
    }
}
