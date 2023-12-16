using System.Diagnostics.CodeAnalysis;

namespace _08_LegendaryFarming
{
    public class Program
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();
            string[] input = Console.ReadLine()
                        .Split()
                        .Select(x => x.ToLower())
                        .ToArray();

            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("shards", 0);

            string resultMaterial = "";

            for (int i = 0; i < input.Length; i += 2)
            {
                int quantity = int.Parse(input[i]);
                string material = input[i + 1];

                if (material == "shards" || material == "fragments" || material == "motes")
                {

                    keyMaterials[material] += quantity;

                    if (keyMaterials[material] >= 250)
                    {

                        if (material == "shards")
                        {
                            resultMaterial = "Shadowmourne";
                        }
                        else if (material == "fragments")
                        {
                            resultMaterial = "Valanyr";
                        }
                        else if (material == "motes")
                        {
                            resultMaterial = "Dragonwrath";
                        }

                        Console.WriteLine($"{resultMaterial} obtained!");
                        keyMaterials[material] = 0;
                        break;
                    }
                }
                else
                {
                    if (!junkMaterials.ContainsKey(material))
                    {
                        junkMaterials.Add(material, quantity);
                    }
                    else
                    {
                        junkMaterials[material] = quantity;
                    }
                }
            }

            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value)
                                                 .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}