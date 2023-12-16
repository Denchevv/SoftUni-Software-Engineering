namespace _05_WordFilter
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                    .Split()
                    .Where(w=>w.Length % 2 == 0)
                    .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}