namespace _11_MultiplyBigNumber2
{
    public class Program
    {
        public static void Main()
        {
            string bigNum = Console.ReadLine().TrimStart('0');
            int inputNum = int.Parse(Console.ReadLine());

            string reversedNum = string.Join("", bigNum.ToCharArray().Reverse());

            string resultNum = string.Empty;
            int result = 0;
            int inMind = 0;

            if (inputNum == 0 || bigNum == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < bigNum.Length; i++)
                {
                    int firstDigit = int.Parse(reversedNum[i].ToString());

                    result = firstDigit * inputNum + inMind;

                    resultNum = result % 10 + resultNum;

                    inMind = result / 10;

                    if (inMind != 0 && i == bigNum.Length - 1)
                    {
                        resultNum = inMind + resultNum;
                    }
                }
            }
            Console.WriteLine(resultNum);
        }
    }
}