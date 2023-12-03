using System.Diagnostics.Metrics;

namespace _16_NumberOccurance
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                        .Split()
                        .Select(double.Parse)
                        .ToArray();

           var dictionary = new SortedDictionary<double, int>();

           foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                   dictionary[number]++;
                }
                else
                {
                    dictionary[number] = 1;
                }
            }

            foreach(var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}