using System;
using System.Windows.Forms;
using MicrOS_DevTools_Updater.Settings;
using MicrOS_DevTools_Updater.Updater;

namespace MicrOS_DevTools_Updater.Forms
{
    public partial class MainForm : Form
    {
        private readonly SettingsManager _settingsManager;
        private readonly VersionChecker _versionChecker;
        private readonly ProcessTerminator _processTerminator;
        private SettingsContainer _settingsContainer;

        public MainForm()
        {
            _settingsManager = new SettingsManager();
            _versionChecker = new VersionChecker();
            _processTerminator = new ProcessTerminator();

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, System.EventArgs e)
        {
            _settingsContainer = await _settingsManager.LoadAsync("settings.json");

            var remoteAppVersion = await _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);
            if (remoteAppVersion != _settingsContainer.AppVersion)
            {
                var result = MessageBox.Show(
                    "Dostępna jest nowa wersja aplikacji MicrOS DevTools. Czy chcesz ją teraz zaktualizować?",
                    "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _processTerminator.Terminate("MicrOS DevTools");
                }
                else if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
