namespace _11MaxSequenceOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] result;

            int lengthMeasure = 1;
            int maxLength = int.MinValue;
            int index = -1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                int currentNum = numbers[i];
                int nextNum = numbers[i + 1];
                if (currentNum == nextNum)
                {
                    lengthMeasure++;
                    if (lengthMeasure > maxLength)
                    {
                        maxLength = lengthMeasure;
                        index = i;
                    }
                }
                else
                {
                    lengthMeasure = 1;
                }

            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{numbers[index]} ");

            }
        }
    }
}