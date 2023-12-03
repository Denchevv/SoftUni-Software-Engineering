namespace _13_GaussTrick
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToList();

            var resultList = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentNum = numbers[i];
                int lastNum = numbers[numbers.Count - 1 - i];
                resultList.Add(currentNum + lastNum);              
            }

            if (numbers.Count % 2 == 1)
            {
                int middleNum = numbers[numbers.Count / 2];
                resultList.Add(middleNum);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}