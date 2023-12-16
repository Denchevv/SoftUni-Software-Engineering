namespace _22_TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            IsItTopNumber(number);

            static void IsItTopNumber(int number)
            {
                for (int i = 1; i <= number; i++)
                {
                    int currentNum = i;
                    if (IsItDivisibleBy8(currentNum) && HoldsOddDigit(currentNum))
                    {
                        Console.WriteLine(currentNum);
                    }
                }
            }

            static bool IsItDivisibleBy8(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum % 8 == 0 ? true : false;

            }

            static bool HoldsOddDigit(int number)
            {

                while (number > 0)
                {
                    int lastDigit = number % 10;
                    if (lastDigit % 2 == 1)
                    {
                        return true;
                    }
                    number /= 10;
                }

                return false;
            }
        }
    }
}