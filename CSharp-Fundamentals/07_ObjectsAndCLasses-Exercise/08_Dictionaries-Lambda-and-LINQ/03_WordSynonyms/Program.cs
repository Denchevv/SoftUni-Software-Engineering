namespace _03_WordSynonyms
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var synonimDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonimDict.Keys.Contains(word))
                {
                    synonimDict[word] = new List<string>();
                }
                synonimDict[word].Add(synonim);
            }


            foreach(var word in synonimDict)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}