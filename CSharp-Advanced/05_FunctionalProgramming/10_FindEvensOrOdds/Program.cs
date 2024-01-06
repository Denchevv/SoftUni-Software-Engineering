namespace _10_FindEvensOrOdds
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string querry = Console.ReadLine();

            Predicate<int> predicate = querry == "odd" 
                ? number => number % 2 == 1 
                : new Predicate<int>(number => number % 2 == 0);
            
            var resultList = new List<int>();
            
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (predicate(i))
                {
                    resultList.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
