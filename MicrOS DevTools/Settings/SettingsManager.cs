using System.IO;
using Newtonsoft.Json;

namespace MicrOS_DevTools.Settings
{
    public class SettingsManager
    {
        public SettingsContainer Load(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                return new SettingsContainer();
            }

            using (var settingsFile = new StreamReader(path))
            {
                var content = settingsFile.ReadToEnd();
                return JsonConvert.DeserializeObject<SettingsContainer>(content) ?? new SettingsContainer();
            }
        }

        public void Save(string path, SettingsContainer settingsContainer)
        {
            var serializedSettings = JsonConvert.SerializeObject(settingsContainer);
            using (var settingsFile = new StreamWriter(path, false))
            {
                settingsFile.Write(serializedSettings);
            }
        }
    }
}
