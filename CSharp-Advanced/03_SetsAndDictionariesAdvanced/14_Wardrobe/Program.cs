
namespace _14_Wardrobe
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            FillDictionary(wardrobe, n);

            string[] wantedClothes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            PrintResult(wardrobe, wantedClothes);

        }
        static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string[] wantedClothes)
        {
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var kvp2 in kvp.Value)
                {
                    if (kvp.Key == wantedClothes[0] && kvp2.Key == wantedClothes[1])
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
                    }
                }
            }
        }

        static void FillDictionary(Dictionary<string, Dictionary<string, int>> wardrobe, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];
                string[] clothes = tokens[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string clothess in clothes)
                {
                    if (wardrobe[color].ContainsKey(clothess) == false)
                    {
                        wardrobe[color].Add(clothess, 0);
                    }

                    wardrobe[color][clothess]++;
                }
            }
        }
    }
}
