using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.ConfigGenerator
{
    public class FileContentReplacer
    {
        public Dictionary<string, byte[]> Replace(SettingsContainer settingsContainer, Dictionary<string, byte[]> files)
        {
            var filesWithReplacedContent = new Dictionary<string, byte[]>();
            var replaceMap = GetReplaceMap(settingsContainer);

            foreach(var file in files)
            {
                var updatedString = Encoding.UTF8.GetString(file.Value);

                foreach (var replaceMapElement in replaceMap)
                {
                    updatedString = updatedString.Replace(replaceMapElement.Key, replaceMapElement.Value);
                }

                filesWithReplacedContent[file.Key] = Encoding.UTF8.GetBytes(updatedString);
            }

            return filesWithReplacedContent;
        }

        private Dictionary<string, string> GetReplaceMap(SettingsContainer settingsContainer)
        {
            var map = new Dictionary<string, string>
            {
                { "[PROJECT_PATH]", settingsContainer.ProjectPath },
                { "[QEMU_PATH]", settingsContainer.QemuPath },
                { "[DEBUGGER_PATH]", Path.Combine(settingsContainer.MsysPath, "mingw64/bin/gdb.exe") },
                { "[DEBUGGER_TARGET]", settingsContainer.DebuggerTarget },
                { "[FLOPPY_LETTER]", settingsContainer.FloppyLetter },
                { "[MSYS_PATH]", settingsContainer.MsysPath },
                { "[EXPLICIT_POWERSHELL]", settingsContainer.WindowsVersion == "Windows 7" ? "powershell" : string.Empty }
            };

            foreach (var item in map.ToList())
            {
                map[item.Key] = item.Value.Replace("\\", "/");
            }

            return map;
        }
    }
}
