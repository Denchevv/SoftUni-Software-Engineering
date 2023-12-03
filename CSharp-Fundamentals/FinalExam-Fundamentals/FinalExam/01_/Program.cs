using System;

namespace _01_
{
    public class Program
    {
        public static void Main()
        {
            string originalString = Console.ReadLine();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] token = input.Split();

                string command = token[0];

                switch (command)
                {
                    case "Translate":
                        char symbol = char.Parse(token[1]);
                        char replacementSymb = char.Parse(token[2]);
                        originalString = TranslateString(originalString, symbol, replacementSymb);

                        Console.WriteLine(originalString);
                        break;
                    case "FindIndex":
                        char symbol2 = char.Parse(token[1]);
                        int index = LastIndexOf(originalString, symbol2);

                        Console.WriteLine(index);
                        break;
                    case "Includes":
                        string substring = token[1];
                        bool includes = DoesInclude(originalString, substring);

                        Console.WriteLine(includes);
                        break;
                    case "Start":
                        string substring2 = token[1];
                        bool startsWith = DoesStartWith(originalString, substring2);

                        Console.WriteLine(startsWith);
                        break;
                    case "Lowercase":
                        originalString = originalString.ToLower();

                        Console.WriteLine(originalString);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(token[1]);
                        int countRemoves = int.Parse(token[2]);
                        originalString = originalString.Remove(indexToRemove, countRemoves);

                        Console.WriteLine(originalString);
                        break;
                }
            }

        }

        public static bool DoesStartWith(string originalString, string substring2)
        {
            int subsLength = substring2.Length;
            string startSubstring = originalString.Substring(0, subsLength);

            if(substring2 == startSubstring)
            {
                return true;
            }
            return false;
        }

        public static bool DoesInclude(string originalString, string substring)
        {
            if (originalString.Contains(substring))
            {
                return true;
            }
            return false;
        }

        public static int LastIndexOf(string originalString, char symbol2)
        {
            int index = -1;
            if (originalString.Contains(symbol2))
            {
                index = originalString.LastIndexOf(symbol2);
            }
            return index;
        }

        public static string TranslateString(string originalString, char symbol, char replacementSymb)
        {
            if (originalString.Contains(symbol))
            {
                originalString = originalString.Replace(symbol, replacementSymb);
            }

            return originalString;
        }
    }
}
