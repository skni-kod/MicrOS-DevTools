using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MicrOS_DevTools.ConfigsGenerator;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Forms
{
    public partial class MainForm : Form
    {
        private readonly SettingsManager _settingsManager;
        private readonly DebuggerTargetsGenerator _debuggerTargetsGenerator;
        private readonly FileDownloader _fileDownloader;
        private readonly FileContentReplacer _fileContentReplacer;
        private readonly FileSaver _fileSaver;
        private readonly VersionChecker _versionChecker;
        private SettingsContainer _settingsContainer;

        private const string SettingsPath = "settings.json";

        public MainForm()
        {
            _settingsManager = new SettingsManager();
            _debuggerTargetsGenerator = new DebuggerTargetsGenerator();
            _fileDownloader = new FileDownloader();
            _fileContentReplacer = new FileContentReplacer();
            _fileSaver = new FileSaver();
            _versionChecker = new VersionChecker();

            InitializeComponent();
            InitializeSettings();
            InitializeBindings();

            _fileDownloader.OnDownloadProgress += FileDownloader_OnDownloadProgress;

            RemoteConfigurationVersionLabel.Text = _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);
            LocalConfigurationVersionLabel.Text = _settingsContainer.LocalConfigurationVersion;

            UpdateConnectionStatus();
        }

        private void InitializeBindings()
        {
            var bindings = new Dictionary<Control, string>
            {
                { RepositoryLinkTextBox, "RepositoryLink" },
                { MSYSTextBox, "MsysPath" },
                { QemuTextBox, "QemuPath" },
                { ProjectPathTextBox, "ProjectPath" },
                { FloppyLetterTextBox, "FloppyLetter" },
                { DebuggerTargetComboBox, "DebuggerTarget" },
                { WindowsVersionComboBox, "WindowsVersion" }
            };

            foreach (var binding in bindings)
            {
                binding.Key.DataBindings.Add("Text", _settingsContainer, binding.Value, false,
                    DataSourceUpdateMode.OnPropertyChanged);
            }

            var debuggerTargets = _debuggerTargetsGenerator.Generate(_settingsContainer.ProjectPath);
            DebuggerTargetComboBox.Items.AddRange(debuggerTargets.ToArray());
        }

        private void InitializeSettings()
        {
            _settingsContainer = _settingsManager.Load(SettingsPath);
        }

        private void SelectMSYSButton_Click(object sender, EventArgs e)
        {
            if (SelectMSYSDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                MSYSTextBox.Text = SelectMSYSDirectoryDialog.SelectedPath;
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
                ProjectPathTextBox.Text = SelectMicrOSDirectoryDialog.SelectedPath;
            }
        }

        private void GenerateConfigurationButton_Click(object sender, EventArgs e)
        {
            var filesToDownload = new[]
            {
                "build.sh",
                "build_environment.sh",
                "build_library.sh",
                "clean.sh",
                "launch.json",
                "tasks.json"
            };

            var downloadedFiles = _fileDownloader.Download(_settingsContainer.RepositoryLink, filesToDownload);
            _fileContentReplacer.Replace(_settingsContainer, downloadedFiles);
            _fileSaver.Save(_settingsContainer.ProjectPath, downloadedFiles);
            
            _settingsContainer.LocalConfigurationVersion = _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);
            _settingsManager.Save(SettingsPath, _settingsContainer);

            LocalConfigurationVersionLabel.Text = _settingsContainer.LocalConfigurationVersion;
        }

        private void FileDownloader_OnDownloadProgress(object sender, float e)
        {
            GeneratorProgressBar.Value = (int)e;
        }

        private void CreateEnvironmentButton_Click(object sender, EventArgs e)
        {
            new NewEnvironmentForm(_settingsContainer).ShowDialog();
        }

        private void AllControls_TextChanged(object sender, EventArgs e)
        {
            CreateEnvironmentButton.Enabled = RepositoryLinkTextBox.Text.Length != 0;
            GenerateConfigurationButton.Enabled = 
                RepositoryLinkTextBox.Text.Length != 0 &&
                MSYSTextBox.Text.Length != 0 &&
                QemuTextBox.Text.Length != 0 &&
                ProjectPathTextBox.Text.Length != 0 &&
                FloppyLetterTextBox.Text.Length != 0 &&
                DebuggerTargetComboBox.Text.Length != 0 &&
                WindowsVersionComboBox.Text.Length != 0;
        }

        private void RepositoryLinkTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            if (_versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink) == null)
            {
                ConnectionStatus.BackColor = Color.Red;
            }
            else
            {
                ConnectionStatus.BackColor = Color.LimeGreen;
            }
        }
    }
}
