using System.ComponentModel;

namespace _13_ForceBook
{
    public class Program
    {
        public static void Main()
        {
            var nameSide = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains(" | "))
                {
                    string[] token = line.Split(" | ");

                    string side = token[0];
                    string name = token[1];

                    if (!nameSide.ContainsKey(name))
                    {
                        nameSide[name] = side;
                    }
                }
                else
                {
                    string[] token = line.Split(" -> ");

                    string name = token[0];
                    string side = token[1];

                    nameSide[name] = side;

                    Console.WriteLine($"{name} joins the {side} side!");
                }
            }

            var filteredDict = nameSide.GroupBy(x => x.Value)
                                       .ToDictionary(x => x.Key, x => x.ToDictionary(y => y.Key, y => y.Value)
                                       .OrderByDescending(x => x.Value.Count())
                                       .ThenBy(x => x.Key));


            foreach (var kvp in filteredDict)
            {
                string side = kvp.Key;
                var nameSideValue = kvp;

                foreach(var kvpValue in nameSideValue.)

            }

        }
    }
}