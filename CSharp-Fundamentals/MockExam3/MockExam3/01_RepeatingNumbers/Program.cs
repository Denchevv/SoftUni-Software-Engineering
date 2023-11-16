namespace _01_RepeatingNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbersList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                numbersList.Add(numbers);
            }

            int finalDigit = 0;
            int maxCount = 0;

            for (int i = 1; i <= 10; i++)
            {
                int counter = 0;
                int digit = 0;

                var currentNum = i;
                for (int j = 0; j < numbersList.Count; j++)
                {
                    if (i == numbersList[j])
                    {
                        counter++;
                        digit = currentNum;
                    }
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        finalDigit = digit;
                    }
                    if (counter == maxCount)
                    {
                        finalDigit = Math.Min(finalDigit, digit);
                    }
                }
            }
            Console.WriteLine(finalDigit);
        }
    }
}
