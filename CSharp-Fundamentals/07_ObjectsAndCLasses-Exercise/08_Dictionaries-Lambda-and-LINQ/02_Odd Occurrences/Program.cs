namespace _02_Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();


            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].ToLower();
            }

            var dict = new Dictionary<string, int>();

            for (int i = 0;i < input.Length; i++)
            {
                string word = input[i];
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }

            foreach(var kvp in dict.Where(x=>x.Value%2==1))
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}