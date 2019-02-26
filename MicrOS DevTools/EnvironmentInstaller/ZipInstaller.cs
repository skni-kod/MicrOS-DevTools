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
                await Task.Run(() =>
                {
                    using (var streamReader = new StreamReader(Path.Combine(targetDirectory, fileName)))
                    using (var zipArchive = new ZipArchive(streamReader.BaseStream))
                    {
                        foreach (var fileToExtract in zipArchive.Entries)
                        {
                            var extractedFileName = Path.Combine(targetDirectory, fileToExtract.FullName);
                            if (fileToExtract.Name == string.Empty)
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(extractedFileName));
                                continue;
                            }

                            fileToExtract.ExtractToFile(extractedFileName, true);
                        }
                    }
                });
            }

            File.Delete(Path.Combine(targetDirectory, fileName));
        }
    }
}
