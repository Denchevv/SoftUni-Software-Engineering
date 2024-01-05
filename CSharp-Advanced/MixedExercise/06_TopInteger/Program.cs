namespace _06_TopInteger
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var resultList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBIggest = true;

                for (int j = 1 + i;  j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isBIggest = false;
                        break;
                    }
                }
                if (isBIggest)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
