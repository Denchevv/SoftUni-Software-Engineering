using System;

namespace _03_TitleSearch
{
    public class Program
    {
        public static void Main()
        {
            string originalText = Console.ReadLine();
            int range = int.Parse(Console.ReadLine());

          
                for (int i = 0; i < range; i++)
                {
                    string input = Console.ReadLine();

                    bool containsText = DoesContainTheSequence(originalText, input);

                    if (containsText)
                    {
                        originalText = RemoveTheText(originalText, input);

                        Console.WriteLine(originalText);

                    }
                    else
                    {
                        Console.WriteLine("No such title found!");
                    }
                }
            }

        private static string RemoveTheText(string originalText, string input)
        {
            int startIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymb = input[i];
                for (int j = startIndex; j < originalText.Length; j++)
                {
                    char orignalSymb = originalText[j];
                    if (currentSymb == orignalSymb)
                    {
                        originalText = originalText.Remove(j, 1);
                        startIndex = j;
                        break;
                    }
                }
            }
            return originalText;
        }

        private static bool DoesContainTheSequence(string originalText, string input)
        {
            int startPosition = 0;
            string result = string.Empty;

            for (int j = 0; j < input.Length; j++)
            {
                char letter = input[j];
                for (int k = startPosition; k < originalText.Length; k++)
                {
                    char currentLetter = originalText[k];
                    if (currentLetter == letter)
                    {
                        startPosition = k;
                        result += currentLetter;
                        break;
                    }
                }
            }
            return result == input ? true : false;
        }
    }
}
