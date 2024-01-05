namespace _05_ArrayRotation
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations % numbers.Length; i++)
            {
                int firstNum = numbers[i];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
