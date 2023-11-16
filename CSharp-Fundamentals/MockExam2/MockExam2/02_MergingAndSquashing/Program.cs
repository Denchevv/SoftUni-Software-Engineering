namespace _02_MergingAndSquashing
{
    public class Program
    {
        public static void Main()
        {
            int countRange = int.Parse(Console.ReadLine());
            int[] numbersList = new int[countRange];
            string[] resultMergeList = new string[countRange - 1];
            string[] resultSquashList = new string[countRange - 1];
            string mergeResultNum = "";
            string squashResultNum = "";

            for (int i = 0; i < countRange; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                
                numbersList[i] = numbers;
            }

            for (int i = 0; i < countRange - 1; i++)
            {
                int firstNum = numbersList[i];
                int secondNum = numbersList[i + 1];

                mergeResultNum += firstNum % 10;
                mergeResultNum += (secondNum / 10) % 10;

                resultMergeList[i] = mergeResultNum;
                mergeResultNum = "";
            }

            for(int i=0; i < countRange - 1; i++)
            {
                int firstNum = numbersList[i];
                int secondNum = numbersList[i + 1];

                int firstSecondDigit = firstNum % 10;
                int secondFirstDigit = (secondNum / 10) % 10;
                int middleResult = firstSecondDigit + secondFirstDigit;

                squashResultNum += (firstNum / 10) % 10;
                squashResultNum += middleResult % 10;
                squashResultNum += secondNum % 10;

                resultSquashList[i] = squashResultNum;
                squashResultNum = "";
            }

            Console.WriteLine(string.Join(" ", resultMergeList));
            Console.WriteLine(string.Join(" ", resultSquashList));

        }
    }
}