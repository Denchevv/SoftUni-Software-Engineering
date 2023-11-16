namespace _01_Game
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int[] numbers = new int[input.Length];
           

            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = input[i] - '0';
                    numbers[i] = digit;
                }
            }

            int firstNum = numbers[0];
            int secondNum = numbers[1];
            int thirdNum = numbers[2];


            int result1 = firstNum + secondNum + thirdNum;
            int result2 = firstNum + secondNum * thirdNum;
            int result3 = firstNum * secondNum * thirdNum;
            int result4 = firstNum * secondNum + thirdNum;
            

            List<int> maxNum = new List<int> { result1, result2, result3, result4 };


            Console.WriteLine(maxNum.Max());
        }
    }
}