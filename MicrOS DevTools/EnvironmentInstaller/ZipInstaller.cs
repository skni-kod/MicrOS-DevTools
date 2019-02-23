using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class ZipInstaller
    {
        public void Install(string repositoryPath, string zip, string targetDirectory)
        {
            Directory.CreateDirectory(targetDirectory);

            using (var webClient = new WebClient())
            using (var floppyDataStream = webClient.OpenRead(Path.Combine(repositoryPath, zip)))
            using (var archive = new ZipArchive(floppyDataStream, ZipArchiveMode.Read, false))
            {
                foreach (var entry in archive.Entries.Where(p => p.Length != 0))
                {
                    Directory.CreateDirectory(Path.Combine(targetDirectory, Path.GetDirectoryName(entry.FullName)));
                    entry.ExtractToFile(Path.Combine(targetDirectory, entry.FullName), true);
                }
            }
        }
    }
}
