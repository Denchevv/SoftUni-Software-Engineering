namespace _03_CountUppercaseWords
{
    public class Program
    {
        public static void Main()
        {
            Predicate<string> predicate = str => char.IsUpper(str[0]); // if first letter is uppercase

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(w => predicate(w))
                .ToList()
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
