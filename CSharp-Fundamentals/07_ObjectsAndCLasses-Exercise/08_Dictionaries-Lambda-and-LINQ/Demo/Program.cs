using System.Numerics;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string result = "";

            foreach (char digit in input)
            {
                if (char.IsDigit(digit))
                {
                    result += digit;
                }
            }
            BigInteger number = BigInteger.Parse(result);
            BigInteger finalResult = 0;
            while (true)
            {
               
                while (number > 0)
                {
                    BigInteger digit = number % 10;
                    finalResult += digit;
                    number /= 10;
                }
                if (finalResult <= 9)
                {
                    break;
                }
                else
                {
                    number = finalResult;
                    finalResult = 0;
                }

            }
            Console.WriteLine(finalResult);
        }
    }
}