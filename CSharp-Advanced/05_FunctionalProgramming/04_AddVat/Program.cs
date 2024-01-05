namespace _04_AddVat
{
    public class Program
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(n=>n * 1.2M)
                .ToList()
                .ForEach(n=> Console.WriteLine($"{n:f2}"));
        }
    }
}
