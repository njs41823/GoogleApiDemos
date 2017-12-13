using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MapsDistanceMatrix.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            AboutRichTextBox.Rtf = Properties.Resources.About;
        }

        private void AboutRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while attempting to navigate to " + e.LinkText + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
