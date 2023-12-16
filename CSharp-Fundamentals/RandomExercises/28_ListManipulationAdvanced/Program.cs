namespace _28_ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }


                string[] token = line.Split();
                string command = token[0];

                if (command == "Contains")
                {
                    int currentNum = int.Parse(token[1]);
                    if (numbersList.Contains(currentNum))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    List<int> result = PrintEvenOrOdd(numbersList, 0);
                    Console.WriteLine(string.Join(" ", result));
                }
                else if (command == "PrintOdd")
                {
                    List<int> result = PrintEvenOrOdd(numbersList, 1);
                    Console.WriteLine(string.Join(" ", result));
                }
                else if (command == "GetSum")
                {
                    int result = numbersList.Sum();
                    Console.WriteLine(result);
                }
                else if (command == "Filter")
                {
                    string condition = token[1];
                    int number = int.Parse(token[2]);

                    var result = FilterTheNumbers(numbersList, condition, number);
                    Console.WriteLine(string.Join(" ", result));
                }
                
            }
        }

        private static List<int> FilterTheNumbers(List<int> numbersList, string condition, int number)
        {
            var resultList = new List<int>();
            foreach (var numberInList in numbersList)
            {
                if (condition == "<")
                {
                    if (numberInList < number)
                        resultList.Add(numberInList);
                }
                else if (condition == "<=")
                {
                    if (numberInList <= number)
                        resultList.Add(numberInList);
                }
                else if (condition == ">")
                {
                    if (numberInList > number)
                        resultList.Add(numberInList);
                }
                else if (condition == ">=")
                {
                    if (numberInList >= number)
                        resultList.Add(numberInList);
                }
            }
            return resultList;
        }


         private static List<int> PrintEvenOrOdd(List<int> numbers, int oddOrEven)
        {
            List<int> resultList = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == oddOrEven)
                {
                    resultList.Add(number);
                }
            }
            return resultList;
        }
    }

}