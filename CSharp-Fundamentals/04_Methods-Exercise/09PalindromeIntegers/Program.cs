namespace _09PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;

                }
                else
                {

                    string reversedText = ReversingString(input);
                    bool isPalindrome = IsPalindrome(input, reversedText);
                    Console.WriteLine(isPalindrome);

                }
            }
        }

        private static bool IsPalindrome(string text1, string text2)
        {
            return text1 == text2 ? true : false;
        }
        private static string ReversingString(string input)
        {
            string reversedText = string.Empty;

            foreach (char symbol in input)
            {
                reversedText = symbol + reversedText;
            }
            return reversedText;
        }
    }
}