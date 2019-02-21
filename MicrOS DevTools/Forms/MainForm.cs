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
            if (SelectGDBDialog.ShowDialog() == DialogResult.OK)
            {
                GDBTextBox.Text = SelectGDBDialog.FileName;
            }
        }

        private void SelectMSYSButton_Click(object sender, EventArgs e)
        {
            if (SelectMSYSDialog.ShowDialog() == DialogResult.OK)
            {
                MSYSTextBox.Text = SelectMSYSDialog.FileName;
            }
        }

        private void SelectQemuButton_Click(object sender, EventArgs e)
        {
            if (SelectQemuDialog.ShowDialog() == DialogResult.OK)
            {
                QemuTextBox.Text = SelectQemuDialog.FileName;
            }
        }

        private void SelectMicrOSDirectoryButton_Click(object sender, EventArgs e)
        {
            if (SelectMicrOSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                MicrOSTextBox.Text = SelectMicrOSDirectoryDialog.SelectedPath;
            }
        }

        private void Component_Leave(object sender, EventArgs e)
        {

        }
    }
}
