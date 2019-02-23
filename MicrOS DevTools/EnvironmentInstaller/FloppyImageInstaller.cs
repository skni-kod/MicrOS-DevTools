using System.IO;
using System.Net;
using System.Text;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class FloppyImageInstaller
    {
        public void Install(string repositoryPath, string projectPath)
        {
            Directory.CreateDirectory(Path.Combine(projectPath, "Build"));

            using (var webClient = new WebClient())
            using (var floppyWriter = new StreamWriter(Path.Combine(projectPath, "Build/floppy.img"), false))
            {
                var floppyData = webClient.DownloadData(Path.Combine(repositoryPath, "install/floppy.img"));
                floppyWriter.Write(Encoding.UTF8.GetString(floppyData).ToCharArray());
            }
        }
    }
}
