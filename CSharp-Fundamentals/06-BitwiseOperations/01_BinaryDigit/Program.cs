namespace _01_BinaryDigit
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int counter = 0;
            string resultNum = "";

            while (number > 0)
            {

                int remainder = number % 2;
                if (remainder == 0)
                {
                    counter++;
                }
                resultNum = remainder + resultNum;

                int result = number / 2;
            }
            Console.WriteLine(counter);
            Console.WriteLine(resultNum);
        }
    }
}