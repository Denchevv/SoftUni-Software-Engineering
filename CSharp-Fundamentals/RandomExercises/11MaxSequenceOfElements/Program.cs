namespace _11MaxSequenceOfElements
{
    public class Program
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int maxLength = 1;
            int currentLength = 1;
            int index = 0;
            int betterIndex = 0;
            for (int i = 0; i < firstArr.Length - 1; i++)
            {

                if (firstArr[i] == firstArr[i + 1])
                {
                    currentLength++;
                    index = i;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        betterIndex = i;
                    }
                    else if (currentLength == maxLength)
                    {
                        if (index < betterIndex)
                        {
                            betterIndex = i;
                        }
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{firstArr[betterIndex]} ");
            }
        }
    }
}
