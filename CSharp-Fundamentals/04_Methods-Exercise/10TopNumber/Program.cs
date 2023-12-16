namespace _10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 8; i <= number; i++)
            {
                bool isItDivisibleBy8 = IsItDivisibleByEight(i);
                bool hasOddDigit = HasOddDigit(i);

                if (isItDivisibleBy8 && hasOddDigit)
                {
                    Console.WriteLine(i);
                }
            }    
        }


        public static bool HasOddDigit (int number)
        {
            string convertedText = Convert.ToString(number);
            foreach (int digit in convertedText)
            { 
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsItDivisibleByEight (int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                sum += currentDigit;
            }

            return sum % 8 == 0 ? true : false;

        }
    }
}