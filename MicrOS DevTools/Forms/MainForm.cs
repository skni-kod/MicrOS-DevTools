using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Forms
{
    public partial class MainForm : Form
    {
        private SettingsContainer _settingsContainer = new SettingsContainer();

        public MainForm()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            var _bindings = new Dictionary<Control, string>
            {
                { RepositoryLinkTextBox, "RepositoryLink" },
                { GDBTextBox, "DebuggerPath" },
                { MSYSTextBox, "MsysPath" },
                { QemuTextBox, "QemuPath" },
                { ProjectPathTextBox, "ProjectPath" },
                { FloppyLetterTextBox, "FloppyLetter" }
            };

            foreach (var binding in _bindings)
            {
                binding.Key.DataBindings.Add("Text", _settingsContainer, binding.Value, false,
                    DataSourceUpdateMode.OnPropertyChanged);
            }
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

        private void Component_Leave(object sender, EventArgs e)
        {

        }
    }
}
