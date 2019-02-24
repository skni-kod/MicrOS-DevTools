using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class ZipInstaller
    {
        public async Task InstallAsync(string repositoryPath, string zip, string targetDirectory)
        {
            var fileName = Path.GetFileName(zip);
            Directory.CreateDirectory(targetDirectory);

            using (var webClient = new WebClient())
            {
                await webClient.DownloadFileTaskAsync(Path.Combine(repositoryPath, zip), Path.Combine(targetDirectory, fileName));
                await Task.Run(() => ZipFile.ExtractToDirectory(Path.Combine(targetDirectory, fileName), targetDirectory));
            }

            File.Delete(Path.Combine(targetDirectory, fileName));
        }
    }
}
