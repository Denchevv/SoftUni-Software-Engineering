namespace _11MathOperations
{
    internal class Program
    {

        // / * + -
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int result = 0;
            switch (operation)
            {
                case '/':
                   result = Divide(number1, number2);
                    break;
                case '*':
                    result = Multiply(number1, number2);
                    break;
                case '+':
                    result = Addition(number1, number2);
                    break;
                case '-':
                    result = Substraction(number1, number2);
                    break;
            }
            Console.WriteLine(result);

        }

        public static int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
        public static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public static int Addition(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static int Substraction(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}