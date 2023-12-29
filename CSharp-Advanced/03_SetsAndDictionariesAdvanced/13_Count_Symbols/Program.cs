

namespace _13_Count_Symbols
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> occurances = new SortedDictionary<char, int>();
            FillDictionary(occurances, text);
            PrintResult(occurances);
        }

         static void PrintResult(SortedDictionary<char, int> occurances)
        {
            foreach(var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }

        static void FillDictionary(SortedDictionary<char, int> occurances, string text)
        {
            foreach (char letter in text)
            {
                if (occurances.ContainsKey(letter) == false)
                {
                    occurances.Add(letter, 0);
                }
                occurances[letter]++;
            }
        }
    }
}