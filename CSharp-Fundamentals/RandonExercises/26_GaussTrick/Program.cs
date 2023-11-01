namespace _26_GaussTrick
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();
            List<int> resultList = new List<int>();

            for (int i = 0; i < list.Count / 2; i++) 
            {
                int first = list[i];
                int last = list[list.Count - 1 - i];
                int resultNumber = first + last;
                resultList.Add(resultNumber);

            }
            if(list.Count % 2 == 1 )
            {
                int num = list[list.Count / 2];
                resultList.Add(num);
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}