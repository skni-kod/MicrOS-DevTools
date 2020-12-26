using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class ZipInstaller
    {
        public async Task DownloadAsync(string repositoryPath, string zip, string targetDirectory, DownloadProgressChangedEventHandler downloadProgressHandler)
        {
            var fileName = Path.GetFileName(zip);
            Directory.CreateDirectory(targetDirectory);

            using (var webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += downloadProgressHandler;
                await webClient.DownloadFileTaskAsync(Path.Combine(repositoryPath, zip), Path.Combine(targetDirectory, fileName));            
            }  
        }

        public async Task UnzipAsync(string repositoryPath, string zip, string targetDirectory, Action<int> downloadProgressHandler)
        {
            var fileName = Path.GetFileName(zip);
            await Task.Run(() =>
            {
                using (var streamReader = new StreamReader(Path.Combine(targetDirectory, fileName)))
                using (var zipArchive = new ZipArchive(streamReader.BaseStream))
                {
                    float numberOfExtractedFiles = 0;
                    foreach (var fileToExtract in zipArchive.Entries)
                    {
                        var extractedFileName = Path.Combine(targetDirectory, fileToExtract.FullName);
                        if (fileToExtract.Name == string.Empty)
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(extractedFileName));
                            continue;
                        }

                        fileToExtract.ExtractToFile(extractedFileName, true);
                        numberOfExtractedFiles++;
                        downloadProgressHandler((int)(numberOfExtractedFiles / zipArchive.Entries.Count * 100));
                    }
                }
            });
            File.Delete(Path.Combine(targetDirectory, fileName));
        }
    }
}
