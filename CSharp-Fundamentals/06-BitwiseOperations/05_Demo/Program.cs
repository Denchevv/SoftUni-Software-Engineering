namespace _05_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int num2 = 0;

            int counter = 0;

            while (num > 0)
            {
                int remainder = num % 2;
                if(num2 == remainder)
                {
                    counter++;
                }

                num /= 2;
            }
            Console.WriteLine(counter);
        }
    }
}