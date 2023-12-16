namespace _01SmallesNumberSecondSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int result = GetSmallestNumber(array);
            Console.WriteLine(result);

        }

        public static int GetSmallestNumber(int[] array)
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            return minNumber;

        }
    }
}