namespace _09_SmallestNumber
{
    public class Program
    {
        public static void Main()
        {
            Func<int, int, int> smallestNum = (a, b) => a < b ? a : b;

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int smallestNumber = numbers.Aggregate(smallestNum);

            Console.WriteLine(smallestNumber);
        }
    }
}
