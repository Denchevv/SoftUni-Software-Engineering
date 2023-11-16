namespace _03BalancedNumber
{
    internal class Program
    {
        static void Main()
        {
            
            int resultSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                int[] numbersList = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        int digit = input[i] - '0';
                        numbersList[i] = digit;
                    }
                }
                int firstNum = numbersList[0];
                int secondNum = numbersList[2];
                int result = numbersList[1];

                if (firstNum + secondNum == result)
                {
                    resultSum += int.Parse(input);
                }
                else
                {
                    Console.WriteLine(resultSum);
                    return;
                }
            }
        }
    }
}
