namespace _04_ListOperations
{
    internal class Program
    {
        public static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] token = line.Split();

                string command = token[0];

                if (command == "Add")
                {
                    int number = int.Parse(token[1]);
                    numbersList.Add(number);
                }
                else if(command == "Remove")
                {
                    int index = int.Parse(token[1]);
                    if (index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbersList.RemoveAt(index);
                }
                else if(command == "Insert")
                {
                    int number = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    if(index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbersList.Insert(index, number);
                }
                else if( command == "Shift")
                {
                    string position = token[1];
                    int count = int.Parse(token[2]);

                    if(position == "left")
                    {
                        numbersList = FirstNumBecomesLast(numbersList, count);

                    }
                    else
                    {
                        numbersList = LastNumBecomesFirst(numbersList, count);
                    }

                }
            }
            Console.WriteLine(string.Join(" ", numbersList));

        }

        public static List<int> LastNumBecomesFirst(List<int> numbersList, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastDigit = numbersList[numbersList.Count-1];
                for (int j = numbersList.Count - 1; j > 0 ; j--)
                {
                    numbersList[j] = numbersList[j - 1];
                }
                numbersList[0] = lastDigit;
            }
            return numbersList;
        }

        public static List<int> FirstNumBecomesLast(List<int> numbersList, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstDigit = numbersList[0];
                for (int j = 0; j < numbersList.Count-1; j++)
                {
                    numbersList[j] = numbersList[j + 1];
                }
                numbersList[numbersList.Count-1] = firstDigit;
            }
            return numbersList;
        }
    }
}