namespace _15_RemoveNegative
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x > 0)
                .Reverse()
                .Select(x => x.ToString())
                .ToList()));

        }
    }
}