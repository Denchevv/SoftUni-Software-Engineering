namespace _07_AdvertisementMessage
{
    public class Program
    {
        public static void Main()
        {
            string[] phrases = { "Excellent product.", "Such a great product."
                    , "I always use that product."
                    , "Best product of its category."
                    , "Exceptional product."
                    , "I can't live without this product"};

            string[] events = { "Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome."
                    , "Try it yourself, I am very satisfied."
                    , "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int randomPhrase = random.Next(phrases.Length);
                int eventsPhrase = random.Next(events.Length);
                int authorsPhrase = random.Next(authors.Length);
                int citiesPhrase = random.Next(cities.Length);
                Console.WriteLine($"{phrases[randomPhrase]} {events[eventsPhrase]} {authors[authorsPhrase]} " +
                    $"– {cities[citiesPhrase]}.");
            }
        }
    }
}