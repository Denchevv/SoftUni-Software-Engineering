namespace _21_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string number = Console.ReadLine();

            while (number != "END")
            {
                string reversedString = ReversingString(number);
                bool isItPalindrome = IsItPalindrome(number, reversedString);
               
                if (isItPalindrome)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                number = Console.ReadLine();
            }

        }

        private static string ReversingString(string number)
        {
            string reversedNum = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNum += number[i];
            }
            return reversedNum;
        }
        private static bool IsItPalindrome(string number, string reversedNum)
        {
          return number == reversedNum ? true : false;
                if (number == reversedNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");

                }
               
        }
    }
}