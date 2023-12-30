namespace _05_SliceMe
{
    public class Program
    {
        public static async Task Main()
        {
            int parts = 4;
            byte[] buffer = new byte[4096];
            int totalBytes = 0;

            using (FileStream fs = new FileStream("sliceMe.txt", FileMode.Open, FileAccess.Read))
            {
                int partSize = (int)Math.Ceiling((decimal)fs.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;

                    using (FileStream ofs = new FileStream($"Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (readBytes < partSize && totalBytes < fs.Length)
                        {
                            int bytesToRead = Math.Min(buffer.Length, partSize - readBytes);
                            int bytes = await fs.ReadAsync(buffer, 0, bytesToRead);
                            await ofs.WriteAsync(buffer, 0, bytes);
                            readBytes += bytes;
                            totalBytes += bytes;
                        }
                    }
                }
            }

        }
    }
}
