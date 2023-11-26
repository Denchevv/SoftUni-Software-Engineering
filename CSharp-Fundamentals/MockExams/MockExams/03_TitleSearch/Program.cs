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

                bool containsText = DoesContainTheText(originalText, input);

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
            for (int i = 0;i < input.Length;i++)
            {
                char currentSymb = input[i];
                for(int j = 0;j < originalText.Length; j++)
                {
                    char orignalSymb = originalText[j];
                    if(currentSymb == orignalSymb)
                    {
                        originalText = originalText.Remove(j, 1);
                        break;
                    }
                }
            }
            return originalText;
        }

        private static bool DoesContainTheText(string originalText, string input)
        {
           
            for (int j = 0; j < input.Length; j++)
            {
                char letter = input[j];

                if (!originalText.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

//UNIFISHED