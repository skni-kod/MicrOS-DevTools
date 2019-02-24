using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MicrOS_DevTools_Updater.Settings
{
    public class SettingsManager
    {
        private string _fileName;

        public SettingsManager(string fileName)
        {
            _fileName = fileName;
        }

        public async Task<SettingsContainer> LoadAsync()
        {
            if (!File.Exists(_fileName))
            {
                return new SettingsContainer();
            }

            using (var settingsFile = new StreamReader(_fileName))
            {
                var content = await settingsFile.ReadToEndAsync();
                return JsonConvert.DeserializeObject<SettingsContainer>(content) ?? new SettingsContainer();
            }
        }

        public async Task SaveAsync(SettingsContainer settingsContainer)
        {
            var serializedSettings = JsonConvert.SerializeObject(settingsContainer);
            using (var settingsFile = new StreamWriter(_fileName, false))
            {
                await settingsFile.WriteAsync(serializedSettings);
            }
        }
    }
}
