namespace _09MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(Math.Abs(number));

            Console.WriteLine(result);


        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;

        }

        public static int GetSumOfEvenDigits(int number)
        {
            int result = GetSumOfDigits(number, 0);
            return result;
        }

        public static int GetSumOfOddDigits(int number)
        {
            int result = GetSumOfDigits(number, 1);
            return result;
        }
        public static int GetSumOfDigits(int number, int expectedNumber)
        {
            int sum = 0;
            int lastDigit = 0;
            while (number > 0)
            {
                lastDigit = number % 10;
                if (lastDigit % 2 == expectedNumber)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }
            return sum;

        }
    }

}