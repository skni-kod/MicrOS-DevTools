using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class FileDownloader
    {
        public event EventHandler<float> OnDownloadProgress;

        public Dictionary<string, string> Download(string link, params string[] fileNames)
        {
            var downloadedFiles = new Dictionary<string, string>();
            var webClient = new WebClient
            {
                BaseAddress = link
            };

            var index = 1;
            foreach (var fileName in fileNames)
            {
                var content = webClient.DownloadData(fileName);
                downloadedFiles.Add(fileName, Encoding.ASCII.GetString(content));

                OnDownloadProgress?.Invoke(this, index++ * 100f / fileNames.Length);
            }

            return downloadedFiles;
        }
    }
}
