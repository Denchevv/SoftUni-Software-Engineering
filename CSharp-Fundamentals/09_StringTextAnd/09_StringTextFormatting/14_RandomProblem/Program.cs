namespace _14_RandomProblem
{
    public class Program
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int otherNumber = int.Parse(Console.ReadLine());

            string resultNumber = string.Empty;
            int result = 0;
            int inMind = 0;

            if(bigNumber == "0" || otherNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());

                result = currentDigit * otherNumber + inMind;

                resultNumber = result % 10 + resultNumber;

                inMind = result / 10;
                if(i == 0 && inMind != 0)
                {
                    resultNumber = inMind + resultNumber;
                }
            }

            Console.WriteLine(resultNumber);
        }
    }
}