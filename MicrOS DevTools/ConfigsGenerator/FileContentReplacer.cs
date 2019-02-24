using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class FileContentReplacer
    {
        public void Replace(SettingsContainer settingsContainer, Dictionary<string, byte[]> files)
        {
            var replaceMap = GetReplaceMap(settingsContainer);
            for(var i=0; i<files.Count; i++)
            {
                var file = files.ElementAt(i);
                var updatedString = Encoding.UTF8.GetString(file.Value);

                foreach (var replaceMapElement in replaceMap)
                {
                    updatedString = updatedString.Replace(replaceMapElement.Key, replaceMapElement.Value.Replace("\\", "/"));
                }

                files[file.Key] = Encoding.UTF8.GetBytes(updatedString);
            }
        }

        private Dictionary<string, string> GetReplaceMap(SettingsContainer settingsContainer)
        {
            return new Dictionary<string, string>
            {
                { "[PROJECT_PATH]", settingsContainer.ProjectPath },
                { "[QEMU_PATH]", settingsContainer.QemuPath },
                { "[DEBUGGER_PATH]", Path.Combine(settingsContainer.MsysPath, "mingw64/bin/gdb.exe") },
                { "[DEBUGGER_TARGET]", settingsContainer.DebuggerTarget },
                { "[FLOPPY_LETTER]", settingsContainer.FloppyLetter },
                { "[MSYS_PATH]", settingsContainer.MsysPath },
                { "[EXPLICIT_POWERSHELL]", settingsContainer.WindowsVersion == "Windows 7" ? "powershell" : string.Empty }
            };
        }
    }
}
