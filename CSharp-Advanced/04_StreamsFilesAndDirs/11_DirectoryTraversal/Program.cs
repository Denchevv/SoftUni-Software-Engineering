namespace _11_DirectoryTraversal
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<FileInfo>> filesByExtensions = new Dictionary<string, List<FileInfo>>();

            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;

                if (filesByExtensions.ContainsKey(extension) == false)
                {
                    filesByExtensions[extension] = new List<FileInfo>();
                }
                filesByExtensions[extension].Add(info);
            }

            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var kvp in filesByExtensions
                    .OrderByDescending(x=>x.Value.Count)
                    .ThenBy(x=>x.Key))
                {
                    writer.Write(kvp.Key);  
                    foreach(var fileInfo in kvp.Value.OrderBy(x=> Math.Ceiling((double)x.Length / 1024)))
                    {
                       writer.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)
                           fileInfo.Length / 1024)}kb");
                    }
                }
            }

        }
    }
}
