using System.Collections.Generic;
using System.IO;

namespace MicrOS_DevTools.ConfigsGenerator
{
    public class FileSaver
    {
        public void Save(string path, Dictionary<string, string> files)
        {
            Directory.CreateDirectory(Path.Combine(path, ".vscode"));
            Directory.CreateDirectory(Path.Combine(path, "Scripts"));

            foreach (var file in files)
            {
                var targetDirectory = GetTargetDirectory(path, file.Key);
                var targetFileName = Path.Combine(targetDirectory, file.Key);

                using (var fileWriter = new StreamWriter(targetFileName))
                {
                    fileWriter.Write(file.Value);
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
