namespace _04_Largest3Numbers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = numbers.OrderByDescending(x => x).ToArray();

            int range = 3 <= numbers.Length ? 3 : numbers.Length;

            for (int i = 0; i < range; i++)
            {
               
                    Console.Write($"{result[i]} ");

            }
        }
    }
}