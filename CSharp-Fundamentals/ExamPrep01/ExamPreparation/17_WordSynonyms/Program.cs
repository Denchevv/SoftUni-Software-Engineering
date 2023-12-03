namespace _17_WordSynonyms
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var synonyms = new Dictionary <string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }
                synonyms[word].Add(synonym);
            }

            foreach (var kvp in synonyms)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}