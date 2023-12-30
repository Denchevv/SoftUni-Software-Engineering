namespace ConsoleApp1
{
    public class Program
    {
        public static async Task Main()
        {
            using(StreamReader str = new StreamReader("input.txt"))
            {
                int currentLine = 0;

                string line = await str.ReadLineAsync();

                while(line != null)
                {
                    if (currentLine % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    currentLine++;
                    line = await str.ReadLineAsync();
                }
            }
        }
    }
}
