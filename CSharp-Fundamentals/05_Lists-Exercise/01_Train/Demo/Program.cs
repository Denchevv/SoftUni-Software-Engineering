namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();
            numbersList.Reverse();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int firstDigit = numbersList[0];
                for (int j = 0; j < numbersList.Count - 1; j++)
                {
                    numbersList[j] = numbersList[j + 1];
                }
                numbersList[numbersList.Count - 1] = firstDigit;
            }
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}