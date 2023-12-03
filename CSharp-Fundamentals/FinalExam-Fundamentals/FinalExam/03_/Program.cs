namespace _03_
{
    public class Program
    {
        public static void Main()
        {
            string[] wordsAndDefinitions = Console.ReadLine().Split(" | ");

            var dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < wordsAndDefinitions.Length; i++)
            {
                string[] token = wordsAndDefinitions[i].Split(": ");

                string word = token[0];
                string definition = token[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }
                dictionary[word].Add(definition);
            }

            string[] testWords = Console.ReadLine().Split(" | ");

            string command = Console.ReadLine();

            if (command == "Test")
            {
                foreach (var kvp in dictionary)
                {

                    string wordName = kvp.Key;
                    if (testWords.Contains(wordName))
                    {
                        Console.WriteLine($"{wordName}:");

                        foreach (var definition in kvp.Value)
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var kvp in dictionary)
                {
                    string words = kvp.Key;
                    Console.Write($"{words} ");
                }
            }

        }

    }
}
