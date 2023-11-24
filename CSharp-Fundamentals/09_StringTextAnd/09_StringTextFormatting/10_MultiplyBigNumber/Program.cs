namespace _10_MultiplyBigNumber
{
    public class Program
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            int secondNum =int.Parse(Console.ReadLine());

            string reversed = string.Join("", firstNum.ToCharArray().Reverse());

            int inMind = 0;
            string resultNum = "";

            if(firstNum == "0" || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < firstNum.Length; i++)
            {
                int firstDigit = int.Parse(reversed[i].ToString());

                int result = firstDigit * secondNum + inMind;

                resultNum = result % 10 + resultNum;

                inMind = result / 10;

                if(i == firstNum.Length - 1 && inMind != 0)
                {
                    resultNum = inMind + resultNum;

                }
            }
           
            Console.WriteLine(resultNum);
        }
    }
}