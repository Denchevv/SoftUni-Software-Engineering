namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Random random = new Random();

            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            List<string> events = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>()
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            List<string> cities = new List<string>()
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };



            for (int i = 0; i < number; i++)
            {
                string resultPhrases = phrases[random.Next(phrases.Count)];
                string resultEvents = events[random.Next(events.Count)];
                string resultAuthors = authors[random.Next(authors.Count)];
                string resultCities = cities[random.Next(cities.Count)];
                Console.WriteLine($"{resultPhrases} {resultEvents} {resultAuthors} – {resultCities}");
            }

        }

       
    }
}
