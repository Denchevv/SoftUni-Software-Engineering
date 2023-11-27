namespace _06_WordAnagrams
{
    public class Program
    {
        public static void Main()
        {
            string originalWord = Console.ReadLine();
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string word = Console.ReadLine();

                bool isAnagram = IsTheWordAnagram(originalWord, word);

                if(isAnagram)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
          
            }
        }

        public static bool IsTheWordAnagram(string originalWord, string word)
        {
            for (int i = 0;i < word.Length;i++)
            {
                char currentLetter = word[i];

                if (!originalWord.Contains(currentLetter))
                {
                    return false;
                }
            }

            return originalWord.Length == word.Length ? true : false;
        }
    }
}