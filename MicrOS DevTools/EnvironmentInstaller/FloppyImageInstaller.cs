using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MicrOS_DevTools.EnvironmentInstaller
{
    public class FloppyImageInstaller
    {
        public async Task InstallAsync(string repositoryPath, string projectPath)
        {
            Directory.CreateDirectory(Path.Combine(projectPath, "Build"));

            using (var webClient = new WebClient())
            using (var floppyWriter = new StreamWriter(Path.Combine(projectPath, "Build/floppy.img"), false))
            {
                var floppyData = await webClient.DownloadDataTaskAsync(Path.Combine(repositoryPath, "install/floppy.img"));
                await floppyWriter.WriteAsync(Encoding.UTF8.GetString(floppyData).ToCharArray());
            }
        }
    }
}
