namespace _27_MergingLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> listOne = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            List<int> listTwo = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();

            List<int> remainingDigits = new List<int>();
            
            List<int> resultList = new List<int>();

            int length = 0;
            bool lengthsAreEqual = (listOne.Count == listTwo.Count);

            if (!lengthsAreEqual)
            {
                if (listOne.Count > listTwo.Count)
                {
                    length = listTwo.Count;
                    for (int i = length; i < listOne.Count; i++)
                    {
                        remainingDigits.Add(listOne[i]);
                    }
                }
                else 
                {
                    length = listOne.Count;
                    for (int i = length; i < listTwo.Count; i++)
                    {
                        remainingDigits.Add(listTwo[i]);
                    }
                }
            }
            else
            {
                length = listOne.Count;
            }
            for (int i = 0; i < length; i++)
            {
                resultList.Add(listOne[i]);
                resultList.Add(listTwo[i]);
            }
            if (!lengthsAreEqual)
            {
                for (int i = 0;i < remainingDigits.Count; i++)
                {
                    resultList.Add(remainingDigits[i]);

                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}