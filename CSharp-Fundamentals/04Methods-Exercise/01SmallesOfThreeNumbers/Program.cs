namespace _01SmallesOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int result = GetSmallestNumber(numberOne, numberTwo, numberThree);
            
            Console.WriteLine(result);
        }
        public static int GetSmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
           int firstSmaller = numberOne<=numberTwo ? numberOne : numberTwo;
            int secondSmaller = numberOne <= numberThree ? numberOne : numberThree;

            return firstSmaller<= secondSmaller ? firstSmaller : secondSmaller;
           
        }
    }

}