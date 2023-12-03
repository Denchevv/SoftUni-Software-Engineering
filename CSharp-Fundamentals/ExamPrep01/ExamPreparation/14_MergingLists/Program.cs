namespace _14_MergingLists
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
            
            var numbers2 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            var resultList = new List<int>();
             
            int minCount = Math.Min(numbers.Count, numbers2.Count);

            for (int i = 0; i < minCount; i++)
            {
                resultList.Add(numbers[i]);
                resultList.Add(numbers2[i]);
            }

            var biggerList = numbers.Count > numbers2.Count ? numbers : numbers2;

            for (int i = minCount; i < biggerList.Count; i++)
            {
                resultList.Add(biggerList[i]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}