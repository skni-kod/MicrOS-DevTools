using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.ConfigGenerator
{
    public class FileDownloader
    {
        public event EventHandler<float> OnDownloadProgress;

        public async Task<Dictionary<string, byte[]>> DownloadAsync(string link, params string[] fileNames)
        {
            var downloadedFiles = new Dictionary<string, byte[]>();
            using (var webClient = new WebClient { BaseAddress = link })
            {
                var index = 1;
                foreach (var fileName in fileNames)
                {
                    var content = await webClient.DownloadDataTaskAsync(fileName);
                    downloadedFiles.Add(fileName, content);

                    OnDownloadProgress?.Invoke(this, index++ * 100f / fileNames.Length);
                }

                return downloadedFiles;
            }
        }
    }
}
