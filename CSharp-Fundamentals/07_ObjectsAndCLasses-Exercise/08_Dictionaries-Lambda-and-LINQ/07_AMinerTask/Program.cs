using System.Collections.Generic;

namespace _07_AMinerTask
{
    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(input))
                {
                    dict[input] = quantity;
                    
                }
                else
                {
                    dict[input] += quantity;

                }

            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}