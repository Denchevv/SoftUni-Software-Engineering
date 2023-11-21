    namespace _03_Substring
    {
        public class Program
        {
            public static void Main()
            {
                string wordToRemove = Console.ReadLine();
                string text = Console.ReadLine();
                string resultText = "";

                while(text.Contains(wordToRemove))
                {
                    int startIndexOf = text.IndexOf(wordToRemove);
                    text = text.Remove(startIndexOf, wordToRemove.Length);

                }
                Console.WriteLine(text);

            }
        }
    }