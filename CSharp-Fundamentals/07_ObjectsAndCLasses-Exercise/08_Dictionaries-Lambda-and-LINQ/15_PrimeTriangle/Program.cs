namespace _15_PrimeTriangle
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int primeCounter = 1;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    primeCounter++;                
                }
                counter = 0;
            }

            for (int i = 1; i <= primeCounter; i++)
            {
                int range = i;
                for (int j = 1; j <= range; j++)
                {
                    int printingNum = 0;
                    if (IsItPrimeNumber(j) || j == 1)
                    {
                        printingNum = 1;
                    }
                    
                    Console.Write(printingNum);

                    if (!IsItPrimeNumber(j))
                    {
                        range += 1;
                    }
                }
                
                Console.WriteLine();              
            }
        }

        public static bool IsItPrimeNumber(int number)
        {
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2 || number == 1)
            {
                return true;
            }
            return false;

        }
    }
}