using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MicrOS_DevTools.EnvironmentInstaller;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Forms
{
    public partial class NewEnvironmentForm : Form
    {
        private readonly FloppyImageInstaller _floppyImageInstaller;
        private readonly ZipInstaller _zipInstaller;
        private readonly SettingsContainer _settingsContainer;

        private readonly List<string> ImagesToDownload = new List<string> { "floppy.img", "hdd.img" };

        private const string DownloadingFloppyString = "pobieranie obrazów";
        private const string DownloadingAdditionalToolsString = "pobieranie dodatkowych narzędzi";
        private const string UnzipingAdditionalToolsString = "rozpakowywanie dodatkowych narzędzi";
        private const string DownloadingCompilerString = "pobieranie kompilatora";
        private const string UnzipingCompilerString = "rozpakowywanie kompilatora";
        private const string ConfiguringMsys2String = "konfiguracja MSYS2";
        private const string ReadyString = "gotowe";

        private const string Msys2ParametersString = "-defterm -mingw64 -no-start -here -c \"pacman -S mingw-w64-x86_64-gcc mingw-w64-x86_64-gdb make bison flex gmp-devel mpc-devel mpfr-devel texinfo diffutils --noconfirm\"";

        private const string VisualStudioCodeInstallerLinkString = "https://code.visualstudio.com/download";
        private const string QemuInstallerLinkString = "https://qemu.weilnetz.de/w64/2018/qemu-w64-setup-20181127.exe";
        private const string ImdiskInstallerLinkString = "https://sourceforge.net/projects/imdisk-toolkit/files/20190130/ImDiskTk-x64.exe";
        private const string Msys2InstallerLink = "http://repo.msys2.org/distrib/x86_64/msys2-x86_64-20180531.exe";


        public NewEnvironmentForm(SettingsContainer settingsContainer)
        {
            InitializeComponent();
            _settingsContainer = settingsContainer;

            var bindings = new Dictionary<Control, string>
            {
                { MSYSTextBox, "MsysPath" },
                { ProjectPathTextBox, "ProjectPath" }
            };

            foreach (var binding in bindings)
            {
                binding.Key.DataBindings.Add("Text", _settingsContainer, binding.Value, false,
                    DataSourceUpdateMode.OnPropertyChanged);
            }

            _floppyImageInstaller = new FloppyImageInstaller();
            _zipInstaller = new ZipInstaller();
        }

        private void VisualStudioCodeInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(VisualStudioCodeInstallerLinkString);
        }

        private void QemuInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(QemuInstallerLinkString);
        }

        private void ImdiskInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ImdiskInstallerLinkString);
        }

        private void MsysInstallerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Msys2InstallerLink);
        }

        private void SelectMSYSButton_Click(object sender, EventArgs e)
        {
            if (SelectMSYSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                MSYSTextBox.Text = SelectMSYSDirectoryDialog.SelectedPath;
                CreateEnvironmentButton.Enabled = true;
            }
        }

        private async void CreateEnvironmentButton_Click(object sender, EventArgs e)
        {
            CreateEnvironmentButton.Enabled = false;

            StatusLabel.Text = DownloadingFloppyString;
            ProgressBar.Value = 0;
            for (int i = 0; i < ImagesToDownload.Count; ++i)
            {
                StatusLabel.Text = DownloadingFloppyString + ": " + ImagesToDownload[i];
                await _floppyImageInstaller.InstallFileAsync(ImagesToDownload[i], _settingsContainer.RepositoryLink, ProjectPathTextBox.Text, UpdateDownloadPercentage);
                ProgressBar.Value += 20 / ImagesToDownload.Count;
            }
            ProgressBar.Value = 20;

            StatusLabel.Text = DownloadingAdditionalToolsString;
            ProgressBar.Value = 40;
            await _zipInstaller.DownloadAsync(_settingsContainer.RepositoryLink, "install/tools.zip", Path.Combine(ProjectPathTextBox.Text, "tools"), UpdateDownloadPercentage);
            StatusLabel.Text = UnzipingAdditionalToolsString;
            ProgressBar.Value = 50;
            await _zipInstaller.UnzipAsync(_settingsContainer.RepositoryLink, "install/tools.zip", Path.Combine(ProjectPathTextBox.Text, "tools"), UpdateDownloadPercentage);

            StatusLabel.Text = DownloadingCompilerString;
            ProgressBar.Value = 60;
            await _zipInstaller.DownloadAsync(_settingsContainer.RepositoryLink, "install/opt.zip", Path.Combine(MSYSTextBox.Text, ""), UpdateDownloadPercentage);
            StatusLabel.Text = UnzipingCompilerString;
            ProgressBar.Value = 70;
            await _zipInstaller.UnzipAsync(_settingsContainer.RepositoryLink, "install/opt.zip", Path.Combine(MSYSTextBox.Text, ""), UpdateDownloadPercentage);

            StatusLabel.Text = ConfiguringMsys2String;
            ProgressBar.Value = 80;
            Process.Start(Path.Combine(MSYSTextBox.Text, "msys2_shell.cmd"), Msys2ParametersString)?.WaitForExit();

            StatusLabel.Text = ReadyString;
            ProgressBar.Value = 100;

            CreateEnvironmentButton.Enabled = true;
        }

        private void SelectMicrOSDirectoryButton_Click(object sender, EventArgs e)
        {
            if (SelectMicrOSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectPathTextBox.Text = SelectMicrOSDirectoryDialog.SelectedPath;
            }
        }

        private void UpdateDownloadPercentage(object sender, DownloadProgressChangedEventArgs e)
        {
            SubProgressBar.Value = e.ProgressPercentage;
        }
        private void UpdateDownloadPercentage(int progress)
        {
            this.Invoke(new MethodInvoker(() => {
                SubProgressBar.Value = progress;
            }));
        }
    }
}
