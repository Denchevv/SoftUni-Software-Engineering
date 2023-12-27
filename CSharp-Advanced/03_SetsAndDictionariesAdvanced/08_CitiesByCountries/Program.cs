namespace _08_CitiesByCountries
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents
                = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if(continents.ContainsKey(continent) == false)
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (continents[continent].ContainsKey(country) == false)
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach(var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach(var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"  {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
        }
    }
}
