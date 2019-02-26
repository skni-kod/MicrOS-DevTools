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
            using (var fileStream = new FileStream(Path.Combine(projectPath, "Build/floppy.img"), FileMode.OpenOrCreate))
            {
                var floppyData = await webClient.DownloadDataTaskAsync(Path.Combine(repositoryPath, "install/floppy.img"));
                await fileStream.WriteAsync(floppyData, 0, floppyData.Length);
            }
        }
    }
}
