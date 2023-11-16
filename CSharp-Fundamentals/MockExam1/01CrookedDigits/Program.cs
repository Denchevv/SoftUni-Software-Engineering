namespace _01CrookedDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = input.Replace(".", "");

            int sum = 0;

            foreach (char symbDigit in input)
            {
                if (char.IsDigit(symbDigit))
                {
                    sum += symbDigit - '0';
                }
            }

            while (sum > 9)
            {
                int currentSum = 0;
                while (sum > 0)
                {
                    currentSum += sum % 10;
                    sum /= 10;
                }
                sum = currentSum;
            }

            Console.WriteLine(sum);


        }
    }
}