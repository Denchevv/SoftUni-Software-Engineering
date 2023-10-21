namespace _03RemainingElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> secondList = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            List<int> result = new List<int>();

            int minCount = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            List<int> biggerList;

            if(firstList.Count == minCount)
            {
                biggerList = secondList;
            }
            else
            {
                biggerList = firstList;
            }

            for (int i = minCount; i < biggerList.Count; i++)
            {
                result.Add(biggerList[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}