using System.Collections.Generic;
using System.Linq;
using MicrOS_DevTools.Settings;

namespace MicrOS_DevTools.Generators
{
    public class FileContentReplacer
    {
        public void Replace(SettingsContainer settingsContainer, Dictionary<string, string> files)
        {
            var replaceMap = GetReplaceMap(settingsContainer);
            for(int i=0; i<files.Count; i++)
            {
                var file = files.ElementAt(i);
                var updatedString = file.Value;

                foreach (var replaceMapElement in replaceMap)
                {
                    updatedString = updatedString.Replace(replaceMapElement.Key, replaceMapElement.Value.Replace("\\", "/"));
                }

                files[file.Key] = updatedString;
            }
        }

        private Dictionary<string, string> GetReplaceMap(SettingsContainer settingsContainer)
        {
            return new Dictionary<string, string>
            {
                { "[PROJECT_PATH]", settingsContainer.ProjectPath },
                { "[QEMU_PATH]", settingsContainer.QemuPath },
                { "[DEBUGGER_PATH]", settingsContainer.DebuggerPath },
                { "[DEBUGGER_TARGET]", settingsContainer.DebuggerTarget },
                { "[FLOPPY_LETTER]", settingsContainer.FloppyLetter },
                { "[MSYS_PATH]", settingsContainer.MsysPath },
                { "[EXPLICT_POWERSHELL]", settingsContainer.WindowsVersion == "Windows 7" ? "powershell" : string.Empty }
            };
        }
    }
}
