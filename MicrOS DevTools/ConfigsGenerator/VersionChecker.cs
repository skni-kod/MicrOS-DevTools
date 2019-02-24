using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class VersionChecker
    {
        public async Task<string> GetRemoteConfigurationVersion(string path)
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    return await webClient.DownloadStringTaskAsync(Path.Combine(path, "version.txt"));
                }
                catch (Exception ex)
                {
                    if (ex is WebException || ex is ArgumentException || ex is UriFormatException)
                    {
                        return null;
                    }

                    throw;
                }
            }
        }
    }
}
