namespace _03_ProductShop
{
    public class Program
    {
        public static void Main()
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while (command?.ToUpper() != "REVISION")
            {

                string[] tokens = command
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (shops.ContainsKey(shopName) == false)
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                shops[shopName].Add(product, price);

                command = Console.ReadLine();
            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value}");
                }
            }
        }
    }
}
