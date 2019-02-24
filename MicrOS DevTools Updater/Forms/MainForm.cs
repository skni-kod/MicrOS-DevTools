using System.Diagnostics;
using System.Threading;
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
        private readonly FileDownloader _fileDownloader;
        private SettingsContainer _settingsContainer;

        private const string NewUpdateMessageString = "Dostępna jest nowa wersja aplikacji MicrOS DevTools. Czy chcesz ją teraz zaktualizować?";
        private const string UpdateDoneString = "Aktualizacja zakończona";
        private const string DevToolsProcessName = "MicrOS DevTools.exe";

        public MainForm()
        {
            _settingsManager = new SettingsManager("settings.json");
            _versionChecker = new VersionChecker();
            _processTerminator = new ProcessTerminator();
            _fileDownloader = new FileDownloader();

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, System.EventArgs e)
        {
            _settingsContainer = await _settingsManager.LoadAsync();

            var remoteAppVersion = await _versionChecker.GetRemoteConfigurationVersion(_settingsContainer.RepositoryLink);
            if (remoteAppVersion != _settingsContainer.AppVersion)
            {
                var result = MessageBox.Show(NewUpdateMessageString, "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Opacity = 100;

                    _processTerminator.Terminate("MicrOS DevTools");
                    await _fileDownloader.DownloadAndSaveAsync(_settingsContainer.RepositoryLink);

                    Thread.Sleep(500);
                    MessageBox.Show(UpdateDoneString, "Aktualizacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _settingsContainer.AppVersion = remoteAppVersion;
                    await _settingsManager.SaveAsync(_settingsContainer);

                    Process.Start(DevToolsProcessName);
                }
            }

            Application.Exit();
        }
    }
}
