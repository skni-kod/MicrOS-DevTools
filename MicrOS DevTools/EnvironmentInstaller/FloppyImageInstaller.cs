using System.IO;
using System.Net;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class FloppyImageInstaller
    {
        public void Install(string repositoryPath, string projectPath)
        {
            using (var webClient = new WebClient())
            using (var floppyWriter = new StreamWriter(Path.Combine(projectPath, "Build/floppy.img")))
            {
                var floppyData = webClient.DownloadData(Path.Combine(repositoryPath, "install/floppy.img"));
                floppyWriter.Write(floppyData);
            }
        }
    }
}
