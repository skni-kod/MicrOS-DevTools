using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class FloppyImageInstaller
    {
        public async Task InstallAsync(string repositoryPath, string projectPath)
        {
            await InstallFileAsync("floppy.img", repositoryPath, projectPath);
            await InstallFileAsync("hdd.img", repositoryPath, projectPath);
        }

        private async Task InstallFileAsync(string filename, string repositoryPath, string projectPath)
        {
            var localPath = Path.Combine(projectPath, $"build/{filename}");
            var remotePath = Path.Combine(repositoryPath, $"install/{filename}");

            Directory.CreateDirectory(Path.Combine(projectPath, "build"));

            using (var webClient = new WebClient())
            {
                await webClient.DownloadFileTaskAsync(new Uri(remotePath), localPath);
            }
        }
    }
}
