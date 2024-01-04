namespace _09_Words
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> occurances = new Dictionary<string, int>();

            using (StreamReader  reader = new StreamReader("words.txt"))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    string word = line.Split(" "
                        , StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToLower();

                    if( occurances.ContainsKey(word) == false)
                    {
                        occurances.Add(word, 0);
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                using (StreamReader reader = new StreamReader("text.txt"))
                {
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        string[] words = line.Split()
                            .Select(x => x.TrimStart(new char[] { '!', '?', '-', '.', ',' }))
                            .Select(x => x.TrimEnd(new char[] { '!', '?', '-', '.', ',' }))
                            .Select(x => x.ToLower())
                            .ToArray();

                        foreach(string word in words)
                        {
                            if(occurances.ContainsKey(word) )
                            {
                                occurances[word]++;
                            }
                        }

                        line = reader.ReadLine();
                    }

                    foreach(var kvp in occurances.OrderByDescending(x=>x.Value))
                    {
                        writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
