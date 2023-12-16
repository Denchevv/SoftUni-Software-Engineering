namespace _06_CountChars
{
    public class Program
    {
        public static void Main()
        {
            // string input = Console.ReadLine();

            char[] chars = Console.ReadLine()                         
                    .Where(c=>!char.IsWhiteSpace(c))
                    .ToArray();

            var letters = new Dictionary<char, int>();

            foreach (char letter in chars)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters[letter] = 0;
                }
                letters[letter]++;
            }

            foreach (var kvp in letters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}