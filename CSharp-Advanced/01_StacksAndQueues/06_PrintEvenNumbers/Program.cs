namespace _06_PrintEvenNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            Console.WriteLine($"{string.Join(", ", queue.Where(q=>q % 2 == 0).ToArray())}");

        }
    }
}
