using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrOS_DevTools.Forms
{
    public partial class NewEnvironmentForm : Form
    {
        public NewEnvironmentForm()
        {
            InitializeComponent();
        }

        private void QemuInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://qemu.weilnetz.de/w64/2018/qemu-w64-setup-20181127.exe");
        }

        private void ImdiskInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/imdisk-toolkit/files/20190130/ImDiskTk-x64.exe");
        }

        private void MsysInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://repo.msys2.org/distrib/x86_64/msys2-x86_64-20180531.exe");
        }

        private void SelectMSYSButton_Click(object sender, EventArgs e)
        {
            if (SelectMSYSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                MSYSTextBox.Text = SelectMSYSDirectoryDialog.SelectedPath;
                NextStepButton.Enabled = true;
            }
        }
    }
}
