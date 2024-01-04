using System.IO.Compression;

namespace _12_ZipAndExtract
{
    public class Program
    {
        public static void Main()
        {
            ZipFile.CreateFromDirectory(@"D:\Photos\Test", @"D:\Photos\Test2\TestArchive.zip");
            ZipFile.ExtractToDirectory(@"D:\Photos\Test2\TestArchive.zip", @"D:\Photos\Test3");
        }
    }
}
