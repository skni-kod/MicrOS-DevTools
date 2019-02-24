using System.Diagnostics;
using System.Linq;

namespace MicrOS_DevTools_Updater.Updater
{
    public class ProcessTerminator
    {
        public void Terminate(string processName)
        {
            var processes = Process.GetProcesses();
            var targets = processes.Where(p => p.ProcessName == processName);

            foreach(var processToTerminate in targets)
            {
                processToTerminate.Kill();
            }
        }
    }
}
