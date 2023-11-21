namespace _04_FilterdText
{
    public class Program
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                                   .Split(", ");
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string revisedWords = new string('*', word.Length);
                text = text.Replace(word, revisedWords);
            }
            Console.WriteLine(text);
        }
    }
}