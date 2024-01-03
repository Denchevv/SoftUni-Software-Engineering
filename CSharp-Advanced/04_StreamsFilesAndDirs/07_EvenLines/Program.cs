
using System.Text;

namespace _07_EvenLines
{
    public class Program
    {
        public static async Task Main()
        {
            char[] symbToReplace = { '-', ',', '.', '!', '?' };
            using StreamReader reader = new StreamReader("text.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");
            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    line = ReplaceSymbols(symbToReplace, line);
                    line = Replace(line);

                    await writer.WriteLineAsync(line);
                    Console.WriteLine(line); 
                }

                counter++;
            }
        }

        static string Replace(string line)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = line.Split();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[words.Length - i - 1]);
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }

        static string ReplaceSymbols(char[] symbToReplace, string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymb = line[i];
                if (symbToReplace.Contains(currentSymb))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(line[i]);
                }
            }
            return sb.ToString().Trim();
        }
    }
}
