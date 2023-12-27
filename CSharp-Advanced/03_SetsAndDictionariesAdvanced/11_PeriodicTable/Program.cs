namespace _11_PeriodicTable
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                periodicTable.UnionWith(elements);
            }

            List<string> resultElements = periodicTable.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", resultElements));

        }
    }
}
