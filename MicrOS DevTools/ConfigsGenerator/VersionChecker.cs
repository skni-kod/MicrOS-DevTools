using System;
using System.IO;
using System.Net;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class VersionChecker
    {
        public string GetRemoteConfigurationVersion(string path)
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    return webClient.DownloadString(Path.Combine(path, "version.txt"));
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
