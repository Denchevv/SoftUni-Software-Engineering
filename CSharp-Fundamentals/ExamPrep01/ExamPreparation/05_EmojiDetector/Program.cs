using System.Text.RegularExpressions;

namespace _05_EmojiDetector
{ }
public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();

        var matchDigit = Regex.Matches(input, @"\d");

        long coolTreshold = 1;

        foreach (Match match in matchDigit)
        {
            coolTreshold *= int.Parse(match.Value);
        }

        Console.WriteLine($"Cool threshold: {coolTreshold}");

        var matchEmoji = Regex.Matches(input, @"(\*\*|::)[A-Z][a-z]{2,}\1");

        Console.WriteLine($"{matchEmoji.Count} emojis found in the text. The cool ones are:");

        foreach (Match match in matchEmoji)
        {
            int charResult = 0;

            foreach (char symbol in match.Value)
            {
                if(char.IsLetter(symbol))
                {
                    charResult += symbol;
                }
            }
            if (charResult >= coolTreshold)
            {
                Console.WriteLine(match);
            }
        }
    }
}