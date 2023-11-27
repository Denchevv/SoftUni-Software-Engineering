namespace _04_BalancedNumber
{
    public class Program
    {
        public static void Main()
        {
            int totalSum = 0;

            while (true)
            {
                string inputNum = Console.ReadLine();
               
                int firstNum = int.Parse(inputNum[0].ToString());
                int secondNum = int.Parse(inputNum[2].ToString());
                int result = int.Parse(inputNum[1].ToString());

                if (firstNum + secondNum != result)
                {
                    break;
                }
                else if(firstNum + secondNum == result)
                {
                    totalSum += int.Parse(inputNum);
                }
            }
            Console.WriteLine(totalSum);

        }
    }
}