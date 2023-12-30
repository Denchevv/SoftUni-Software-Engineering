namespace _06_FolderSize
{
    public class Program
    {
        public static async Task Main()
        {
            string[] fileNames = Directory.GetFiles("d:/Music/Gym");
            double totalSize = 0;

            foreach (var filename in fileNames)
            {
                FileInfo info = new FileInfo(filename);
                totalSize += info.Length;
            }

            totalSize = totalSize / 1024 / 1024;

            await File.WriteAllTextAsync("output.txt", totalSize.ToString());

        }
    }
}
