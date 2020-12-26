using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class FloppyImageInstaller
    {
        public async Task InstallFileAsync(string filename, string repositoryPath, string projectPath, DownloadProgressChangedEventHandler downloadProgressHandler)
        {
            var localPath = Path.Combine(projectPath, $"build/{filename}");
            var remotePath = Path.Combine(repositoryPath, $"install/{filename}");

            Directory.CreateDirectory(Path.Combine(projectPath, "build"));

            using (var webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += downloadProgressHandler;
                await webClient.DownloadFileTaskAsync(new Uri(remotePath), localPath);
            }
        }
    }
}
