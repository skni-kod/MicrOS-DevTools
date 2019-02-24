using System.Windows.Forms;
using MicrOS_DevTools_Updater.Settings;

namespace MicrOS_DevTools_Updater.Forms
{
    public partial class MainForm : Form
    {
        private readonly SettingsManager _settingsManager;
        private SettingsContainer _settingsContainer;

        public MainForm()
        {
            _settingsManager = new SettingsManager();

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, System.EventArgs e)
        {
            _settingsContainer = await _settingsManager.LoadAsync("settings.json");
        }
    }
}
