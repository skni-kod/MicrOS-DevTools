using System.IO;
using System.Net;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class RemoteVersionChecker
    {
        public string GetRemoteConfigurationVersion(string path)
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    return webClient.DownloadString(Path.Combine(path, "version.txt"));
                }
                catch (WebException)
                {
                    return null;
                }
            }
        }
    }
}
