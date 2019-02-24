using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools_Updater.Updater
{
    public class VersionChecker
    {
        public async Task<string> GetRemoteConfigurationVersion(string path)
        {
            using (var webClient = new WebClient())
            {
                return await webClient.DownloadStringTaskAsync(Path.Combine(path, "app/version.txt"));
            }
        }
    }
}
