using System.Globalization;

namespace _05RemoveNegativesAndReverse
{


    internal class Program
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> result = numbers.ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                
                string[] tokens = line.Split();
                string command = tokens[0];

                int number = int.Parse(tokens[1]);


                switch (command)
                {
                    case "Add":

                        result.Add(number);
                        break;
                    case "Remove":
                        result.Remove(number);
                        break;
                    case "RemoveAt":
                        result.RemoveAt(number);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[2]);
                        result.Insert(index, number);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

    }
}