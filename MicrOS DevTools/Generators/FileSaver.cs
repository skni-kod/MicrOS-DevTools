using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicrOS_DevTools.Generators
{
    public class FileSaver
    {
        public bool CheckIfDirectoriesExist(string path)
        {
            return Directory.Exists(Path.Combine(path, ".vscode")) &&
                   Directory.Exists(Path.Combine(path, "Scripts"));
        }

        public void Save(string path, Dictionary<string, byte[]> files)
        {
            foreach (var file in files)
            {
                var targetDirectory = GetTargetDirectory(path, file.Key);
                var targetFileName = Path.Combine(targetDirectory, file.Key);

                using (var fileWriter = new StreamWriter(targetFileName))
                {
                    fileWriter.Write(Encoding.ASCII.GetString(file.Value));
                }
            }
        }

        private string GetTargetDirectory(string path, string file)
        {
            switch (Path.GetExtension(file))
            {
                case ".json": return Path.Combine(path, ".vscode");
                case ".sh": return Path.Combine(path, "Scripts");
            }

            return null;
        }
    }
}
