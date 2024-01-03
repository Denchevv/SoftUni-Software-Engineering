
namespace _08_LineNumbers
{
    public class Program
    {
        public static async Task Main()
        {
            string[] line = File.ReadAllLines("text.txt");
             
            for(int i = 0;  i < line.Length; i++)
            {
                int[] letterAndMarksCounter = new int[2];
                string currentLine = line[i];

                letterAndMarksCounter = CountingRepetitions(line[i]);

                line[i] = $"Line {i + 1}: {currentLine} ({letterAndMarksCounter[0]})({letterAndMarksCounter[1]})";
            }

            File.WriteAllLines("../../../output.txt", line);
        }

        private static int[] CountingRepetitions(string line)
        {
            int[] resultArr = new int[2];

            string[] words = line.Split(' ');
            char[] symbols = words.SelectMany(w=>w.ToCharArray()).ToArray();
            foreach(char symb in symbols)
            {
                if (char.IsLetter(symb))
                {
                    resultArr[0] ++;
                }
                else
                {
                    resultArr[1] ++;
                }
            }

            return resultArr;
        }
    }
}
