namespace _02_LineNumbers
{
    public class Program
    {
        public static async Task Main()
        {
            using (StreamReader str = new StreamReader("input.txt"))
            {
                string line = await str.ReadLineAsync();
                int counter = 1;

                using (StreamWriter wrt = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        await wrt.WriteLineAsync($"{counter}. {line}");
                        counter++;
                        line = await str.ReadLineAsync();
                    }
                } 
            }
        }
    }
}
