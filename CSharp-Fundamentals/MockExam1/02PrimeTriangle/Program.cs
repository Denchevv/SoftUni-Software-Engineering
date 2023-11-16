using System.Diagnostics.Metrics;

namespace _02PrimeTriangle
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int rowCounter = HowManyPrimeNumbers(number);

            int printNum = 1;

            for (int i = 1; i <= rowCounter; i++)
            {
                int rangeNum = i;

                for (int j = 1; j <= rangeNum; j++)
                {
                    if (!IsItPrime(j) && j != 1)
                    {
                        rangeNum++;
                        printNum = 0;
                    }

                    Console.Write(printNum);
                    printNum = 1;
                }

                Console.WriteLine();
            }
        }

        public static bool IsItPrime(int number)
        {
            int primeCounter = 0;

            for (int j = 1; j <= number; j++)
            {
                if (number % j == 0)
                {
                    primeCounter++;
                }
            }
            if (primeCounter == 2)
            {
                return true;
            }
            return false;

        }

        public static int HowManyPrimeNumbers(int number)
        {
            int rowCounter = 0;

            for (int i = 1; i <= number; i++)
            {
                int primeCounter = 0;
                int currentNumber = i;
                for (int j = 1; j <= currentNumber; j++)
                {
                    if (currentNumber % j == 0)
                    {
                        primeCounter++;
                    }
                }
                if (primeCounter == 2)
                {
                    rowCounter++;
                }
            }
            rowCounter += 1;
            return rowCounter;
        }
    }
}