using System;
using System.Windows.Forms;

namespace MicrOS_DevTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectGDBButton_Click(object sender, EventArgs e)
        {
            SelectGDBDialog.ShowDialog();
        }

        private void SelectMSYSButton_Click(object sender, EventArgs e)
        {
            SelectMSYSDialog.ShowDialog();
        }

        private void SelectQemuButton_Click(object sender, EventArgs e)
        {
            SelectQemuDialog.ShowDialog();
        }

        private void SelectMicrOSDirectoryButton_Click(object sender, EventArgs e)
        {
            SelectMicrOSDirectoryDialog.ShowDialog();
        }
    }
}
