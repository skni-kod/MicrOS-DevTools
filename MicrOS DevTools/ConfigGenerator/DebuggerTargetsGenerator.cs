using System.Collections.Generic;
using System.IO;

namespace MicrOS_DevTools.ConfigGenerator
{
    public class DebuggerTargetsGenerator
    {
        public IEnumerable<string> Generate(string repositoryPath)
        {
            yield return GetKernelTarget(repositoryPath);
            foreach (var target in GetApplicationTargets(repositoryPath))
            {
                yield return target;
            }
        }

        private string GetKernelTarget(string repositoryPath)
        {
            return Path.Combine(repositoryPath, "build\\kernel.elf").Replace(repositoryPath, string.Empty);
        }

        private IEnumerable<string> GetApplicationTargets(string repositoryPath)
        {
            var applicationsDirectoryPath = Path.Combine(repositoryPath, "build\\Floppy\\ENV");
            if (!Directory.Exists(applicationsDirectoryPath))
            {
                yield break;
            }

            foreach (var targetDirectory in Directory.GetFiles(applicationsDirectoryPath))
            {
                yield return targetDirectory.Replace(repositoryPath, string.Empty);
            }
        }
    }
}
