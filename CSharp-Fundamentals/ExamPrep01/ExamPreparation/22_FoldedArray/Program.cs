namespace _22_FoldedArray
{
    public class Program
    {
        static void Main()
        {
            int[] originalArr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int foldedPart = originalArr.Length / 4;

            int[] upperArr = new int[originalArr.Length / 2];
            int[] lowerArr = new int[originalArr.Length / 2];

            // First folded part
            int foldIndex = foldedPart - 1;
            for (int i = 0; i < foldedPart; i++)
            {
                upperArr[i] = originalArr[foldIndex];
                foldIndex--;
            }

            // Last folded part
            originalArr = originalArr.Reverse().ToArray();

            int arrIndex = foldedPart;
            for (int i = 0; i < foldedPart; i++)
            {
                upperArr[arrIndex] = originalArr[i];
                arrIndex++;
            }

            int lowerStartIndex = 0;
            int startLoopIndex = originalArr.Length - 1 - foldedPart;
            for (int i = startLoopIndex; i >= foldedPart; i--)
            {
                lowerArr[lowerStartIndex] = originalArr[i];
                lowerStartIndex++;

            }

            int[] resultArr = new int[upperArr.Length];
            for (int i = 0; i < upperArr.Length; i++)
            {
                int result = upperArr[i] + lowerArr[i];
                resultArr[i] = result;
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
