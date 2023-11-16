namespace _03_AloneNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine()
                            .Split(new char[] { ',' } , StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            int targetNum = int.Parse(Console.ReadLine());

            int[] resultArr = new int[inputArr.Length];
            Array.Copy(inputArr, resultArr, inputArr.Length);

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == targetNum)
                {
                    int indexOfNum = i;
                    bool isAloneNum = HasNumberBeforeAndAfter(inputArr, indexOfNum, targetNum);
                    if (isAloneNum)
                    {
                        int biggerNumIndex = ReturnBiggerNumberOfIndex(inputArr, indexOfNum);
                        resultArr[indexOfNum] = inputArr[biggerNumIndex];
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", resultArr)}]");

        }

        private static int ReturnBiggerNumberOfIndex(int[] inputArr, int indexOfNum)
        {
            int previousNum = inputArr[indexOfNum - 1];
            int nextNum = inputArr[indexOfNum + 1];
            int resultIndex = 0;
            if(previousNum >= nextNum)
            {
                resultIndex = indexOfNum - 1;
            }
            else
            {
                resultIndex = indexOfNum + 1;
            }

            return resultIndex;
        }

        private static bool HasNumberBeforeAndAfter(int[] inputArr, int indexOfNum, int targetNum)
        {
            int indexPrevious = indexOfNum - 1;
            int indexNext = indexOfNum + 1;
            if (indexPrevious >= 0 && indexNext < inputArr.Length)
            {
                if (inputArr[indexPrevious] != targetNum && inputArr[indexNext] != targetNum)
                {
                    return true;

                }
            }
            return false;
        }
    }
}