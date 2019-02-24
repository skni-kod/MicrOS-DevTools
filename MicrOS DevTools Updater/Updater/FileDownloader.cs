using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools_Updater.Updater
{
    public class FileDownloader
    {
        public async Task DownloadAndSaveAsync(string repositoryPath)
        {
            using (var webClient = new WebClient())
            {
                var data = await webClient.DownloadDataTaskAsync(Path.Combine(repositoryPath, "app/MicrOS DevTools.exe"));

                File.Delete("MicrOS DevTools.exe");
                File.WriteAllBytes("MicrOS DevTools.exe", data);
            }
        }
    }
}
