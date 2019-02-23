﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MicrOS_DevTools.EnvironmentInstaller;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Forms
{
    public partial class NewEnvironmentForm : Form
    {
        private readonly FloppyImageInstaller _floppyImageInstaller;
        private readonly ZipInstaller _zipInstaller;
        private SettingsContainer _settingsContainer;

        public NewEnvironmentForm(SettingsContainer settingsContainer)
        {
            InitializeComponent();
            _settingsContainer = settingsContainer;

            _floppyImageInstaller = new FloppyImageInstaller();
            _zipInstaller = new ZipInstaller();
        }

        private void VisualStudioCodeInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://code.visualstudio.com/download");
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
                CreateEnvironmentButton.Enabled = true;
            }
        }

        private void CreateEnvironmentButton_Click(object sender, EventArgs e)
        {
            _floppyImageInstaller.Install(_settingsContainer.RepositoryLink, ProjectPathTextBox.Text);
            _zipInstaller.Install(_settingsContainer.RepositoryLink, "install/tools.zip", Path.Combine(ProjectPathTextBox.Text, "Tools"));
            _zipInstaller.Install(_settingsContainer.RepositoryLink, "install/opt.zip", Path.Combine(MSYSTextBox.Text, ""));

            //var p = Process.Start("D:/MSYS64/msys2_shell.cmd", "-defterm -mingw64 -no-start -here -c Scripts/build.sh");
            //p.WaitForExit();
        }

        private void SelectMicrOSDirectoryButton_Click(object sender, EventArgs e)
        {
            if (SelectMicrOSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectPathTextBox.Text = SelectMicrOSDirectoryDialog.SelectedPath;
            }
        }
    }
}
