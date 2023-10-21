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
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                /* //4 19 2 53 6 43
                 Add 3
                 Remove 2
                 RemoveAt 1
                 Insert 8 3
                 end  */
                switch (line)
                {
                    case "Add":
                        numbers.Add();
                        break;
                    case "Remove":
                        numbers.Add(3);
                        break;
                    case "Add":
                        numbers.Add(3);
                        break;
                    case "Add":
                        numbers.Add(3);
                        break;
                }
            }         
        }
       
    }
}