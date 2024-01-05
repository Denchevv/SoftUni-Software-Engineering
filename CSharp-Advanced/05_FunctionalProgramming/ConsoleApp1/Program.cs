namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int[] evenNums = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x=>x % 2 == 0)
                .OrderBy(x=>x)
                .ToArray();

            Console.WriteLine($"{string.Join(", ", evenNums)}");

            // Not recommended 
/*            Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList()
                .ForEach(x =>
                {
                    Console.Write(x + ", ");
                });*/
        }
    }
}
