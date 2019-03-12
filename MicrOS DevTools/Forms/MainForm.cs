using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicrOS_DevTools.ConfigGenerator;
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

        private Timer _remoteConfigVersionTimer;
        private Timer _updaterTimer;

        private const int RemoteConfigVersionTimerInterval = 1;
        private const int UpdaterTimerIntervalMinutes = 5;

        private const string SettingsPath = "settings.json";
        private const string UpdaterName = "MicrOS DevTools Updater.exe";

        public MainForm()
        {
            _settingsManager = new SettingsManager(SettingsPath);
            _debuggerTargetsGenerator = new DebuggerTargetsGenerator();
            _fileDownloader = new FileDownloader();
            _fileContentReplacer = new FileContentReplacer();
            _fileSaver = new FileSaver();
            _versionChecker = new VersionChecker();

            _remoteConfigVersionTimer = new Timer();
            _remoteConfigVersionTimer.Interval = 1000 * 60 * RemoteConfigVersionTimerInterval;
            _remoteConfigVersionTimer.Tick += RemoteConfigVersionTimer_Elapsed;
            _remoteConfigVersionTimer.Start();

            _updaterTimer = new Timer();
            _updaterTimer.Interval = 1000 * 60 * UpdaterTimerIntervalMinutes;
            _updaterTimer.Tick += UpdaterTimer_Elapsed;
            _updaterTimer.Start();

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await InitializeSettingsAsync();

            RunUpdater();
            InitializeBindings();

            _fileDownloader.OnDownloadProgress += FileDownloader_OnDownloadProgress;

            await UpdateRemoteConfigVersionLabels();
            await UpdateConnectionStatus();
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
                { ThreadsCountNumericUpDown, "ThreadsCount" },
                { DebuggerTargetComboBox, "DebuggerTarget" },
                { WindowsVersionComboBox, "WindowsVersion" }
            };

            if (_settingsContainer.ProjectPath != string.Empty)
            {
                var debuggerTargets = _debuggerTargetsGenerator.Generate(_settingsContainer.ProjectPath);
                DebuggerTargetComboBox.Items.AddRange(debuggerTargets.ToArray<object>());
            }

            foreach (var binding in bindings)
            {
                binding.Key.DataBindings.Add("Text", _settingsContainer, binding.Value, false,
                    DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private async Task InitializeSettingsAsync()
        {
            _settingsContainer = await _settingsManager.LoadAsync();
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

        private async void GenerateConfigurationButton_Click(object sender, EventArgs e)
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

            var downloadedFiles = await _fileDownloader.DownloadAsync(_settingsContainer.RepositoryLink, filesToDownload);
            var filesWithReplacedContent = _fileContentReplacer.Replace(_settingsContainer, downloadedFiles);

            _fileSaver.SaveAsync(_settingsContainer.ProjectPath, filesWithReplacedContent);    
            _settingsContainer.LocalConfigurationVersion = await _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);

            await _settingsManager.SaveAsync(_settingsContainer);
            await UpdateRemoteConfigVersionLabels();
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

            if (((Control) sender).Name == "ProjectPathTextBox")
            {
                DebuggerTargetComboBox.Items.Clear();

                var debuggerTargets = _debuggerTargetsGenerator.Generate(((Control)sender).Text);
                DebuggerTargetComboBox.Items.AddRange(debuggerTargets.ToArray<object>());
            }
        }

        private async void RepositoryLinkTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            await UpdateConnectionStatus();
        }

        private async Task UpdateConnectionStatus()
        {
            var remoteConfigurationVersion = await _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);
            ConnectionStatus.BackColor = remoteConfigurationVersion == null ? Color.Red : Color.LimeGreen;
        }

        private async Task UpdateRemoteConfigVersionLabels()
        {
            LocalConfigurationVersionLabel.Text = _settingsContainer.LocalConfigurationVersion;
            RemoteConfigurationVersionLabel.Text = await _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);

            var color = Color.Black;
            var fontStyle = FontStyle.Regular;

            if (LocalConfigurationVersionLabel.Text != RemoteConfigurationVersionLabel.Text)
            {
                color = Color.Red;
                fontStyle = FontStyle.Bold;
            }

            LocalConfigurationVersionLabel.ForeColor = color;
            LocalConfigurationVersionLabel.Font = new Font(LocalConfigurationVersionLabel.Font, fontStyle);
        }

        private void RunUpdater()
        {
            Process.Start(UpdaterName);
        }

        private async void RemoteConfigVersionTimer_Elapsed(object sender, EventArgs e)
        {
            await UpdateRemoteConfigVersionLabels();
        }

        private void UpdaterTimer_Elapsed(object sender, EventArgs e)
        {
            RunUpdater();
        }
    }
}
