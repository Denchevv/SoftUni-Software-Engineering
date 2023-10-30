namespace _15_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            int result = VowelsCount(input);
            Console.WriteLine(result);
        }

        private static int VowelsCount(string text)
        {
            int result = 0;
            foreach (char letter in text)
            {
                char lowerCaseLetter = char.ToLower(letter);
                result += "aeiou".Contains(lowerCaseLetter) ? 1 : 0;
            }
            return result;
        }
    }
}