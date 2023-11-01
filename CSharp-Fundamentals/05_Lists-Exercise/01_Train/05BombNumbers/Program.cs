namespace _05BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();
            List<int> bombNumberValue = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();

            List<int> currentNumbersList = new List<int>();
            int bombNumber = bombNumberValue[0];
            int bombPower = bombNumberValue[1];


            for (int i = 0; i < numbersList.Count; i++)
            {
                if (bombNumber == numbersList[i])
                {
                    int currentIndex = i;

                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbersList.Count - 1)
                    {
                        endIndex = numbersList.Count - 1;
                    }
                    if (startIndex > numbersList.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }

                    numbersList.RemoveRange(startIndex, endIndex - startIndex +1);
                    i = startIndex -1;
                }
            }
            int result = numbersList.Sum();
            Console.WriteLine(result);
        }
    }
}