using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MicrOS_DevTools.Generators;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Forms
{
    public partial class MainForm : Form
    {
        private readonly SettingsManager _settingsManager;
        private readonly DebuggerTargetsGenerator _debuggerTargetsGenerator;
        private readonly FileDownloader _fileDownloader;
        private SettingsContainer _settingsContainer;

        private const string SettingsPath = "settings.json";

        public MainForm()
        {
            _settingsManager = new SettingsManager();
            _debuggerTargetsGenerator = new DebuggerTargetsGenerator();
            _fileDownloader = new FileDownloader();
            _fileDownloader.OnDownloadProgress += FileDownloader_OnDownloadProgress;

            InitializeComponent();
            InitializeSettings();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            var bindings = new Dictionary<Control, string>
            {
                { RepositoryLinkTextBox, "RepositoryLink" },
                { GDBTextBox, "DebuggerPath" },
                { MSYSTextBox, "MsysPath" },
                { QemuTextBox, "QemuPath" },
                { ProjectPathTextBox, "ProjectPath" },
                { FloppyLetterTextBox, "FloppyLetter" },
                { DebuggerTargetComboBox, "DebuggerTarget" }
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
                ProjectPathTextBox.Text = SelectMicrOSDirectoryDialog.SelectedPath;
            }
        }

        private void GenerateConfigurationButton_Click(object sender, EventArgs e)
        {
            var filesToDownload = new string[]
            {
                "build.sh",
                "build_environment.sh",
                "build_library.sh",
                "clean.sh",
                "launch.json",
                "tasks.json"
            };

            var downloadedFiles = _fileDownloader.Download(_settingsContainer.RepositoryLink, filesToDownload);
            _settingsManager.Save(SettingsPath, _settingsContainer);
        }

        private void FileDownloader_OnDownloadProgress(object sender, float e)
        {
            GeneratorProgressBar.Value = (int)e;
        }
    }
}
