using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MicrOS_DevTools.Settings
{
    public class SettingsManager
    {
        public async Task<SettingsContainer> LoadAsync(string path)
        {
            if (!File.Exists(path))
            {
                return new SettingsContainer();
            }

            using (var settingsFile = new StreamReader(path))
            {
                var content = await settingsFile.ReadToEndAsync();
                return JsonConvert.DeserializeObject<SettingsContainer>(content) ?? new SettingsContainer();
            }
        }

        public async Task SaveAsync(string path, SettingsContainer settingsContainer)
        {
            var serializedSettings = JsonConvert.SerializeObject(settingsContainer);
            using (var settingsFile = new StreamWriter(path, false))
            {
                await settingsFile.WriteAsync(serializedSettings);
            }
        }
    }
}
