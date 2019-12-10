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
            var localPath = Path.Combine(projectPath, "build/floppy.img");
            var remotePath = Path.Combine(repositoryPath, "install/floppy.img");

            Directory.CreateDirectory(Path.Combine(projectPath, "build"));

            using (var webClient = new WebClient())
            {
                await webClient.DownloadFileTaskAsync(new Uri(remotePath), localPath);
            }
        }
    }
}
