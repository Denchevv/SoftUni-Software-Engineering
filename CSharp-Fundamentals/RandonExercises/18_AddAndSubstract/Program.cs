namespace _18_AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int numberOne = Addition(firstNum, secondNum);
            int result = Subtraction(numberOne, thirdNum);
            Console.WriteLine(result);
        }
        static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}