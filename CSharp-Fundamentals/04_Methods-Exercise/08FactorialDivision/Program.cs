namespace _08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double result = GetDivision(GetFactorial(numberOne), GetFactorial(numberTwo));

            Console.WriteLine($"{result:f2}");

        }

        public static long GetFactorial(int number)
        {
            long factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel *=  i;
            }
            return factoriel;
        }

        public static double GetDivision (long numberOne,  long numberTwo)
        {
            double result = (double)numberOne / numberTwo;
            return result;
        }
    }
}