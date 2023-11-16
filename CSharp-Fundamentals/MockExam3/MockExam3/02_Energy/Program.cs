using System.Numerics;

namespace _02_Energy
{
    public class Program
    {
        public static void Main()
        {
            BigInteger numberDrinks = BigInteger.Parse(Console.ReadLine());
            long oddSum = 0;
            long evenSum = 0;

            while (numberDrinks > 0)
            {
                long lastDigit = (long)numberDrinks % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else if (lastDigit % 2 == 1)
                {
                    oddSum += lastDigit;
                }
                numberDrinks /= 10;
            }

            
            if (oddSum > evenSum)
            {
                Console.WriteLine($"{oddSum} cups of coffee");
            }
            else if (evenSum > oddSum)
            {              
                Console.WriteLine($"{evenSum} energy drinks");

            }
            else if (oddSum == evenSum) 
            {
                Console.WriteLine($"{evenSum} of both");
            }

           
        }
    }
}