using System.Collections.Generic;
using System.IO;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class DebuggerTargetsGenerator
    {
        public IEnumerable<string> Generate(string path)
        {
            yield return GetKernelTarget(path);
            foreach (var target in GetApplicationTargets(path))
            {
                yield return target;
            }
        }

        private string GetKernelTarget(string path)
        {
            return Path.Combine(path, "Build\\kernel.elf").Replace(path, string.Empty);
        }

        private IEnumerable<string> GetApplicationTargets(string path)
        {
            var applicationsDirectoryPath = Path.Combine(path, "Build\\Floppy\\ENV");
            if (!Directory.Exists(applicationsDirectoryPath))
            {
                yield break;
            }

            foreach (var targetDirectory in Directory.GetFiles(applicationsDirectoryPath))
            {
                yield return targetDirectory.Replace(path, string.Empty);
            }
        }
    }
}
