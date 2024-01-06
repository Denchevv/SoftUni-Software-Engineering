namespace _12_ReverseAndExclude
{
    public  class Program
    {
        public static void Main()
        {
            
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            Predicate<int> predicate = x => x % n == 0;

            numbers = numbers.Where(x=> !predicate(x)).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
