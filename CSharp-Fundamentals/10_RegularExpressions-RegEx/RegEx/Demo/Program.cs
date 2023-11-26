using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Channels;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            var regex = @"(?:\+359)([ -])2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, regex);

            string[] matchedPhones = phoneMatches
             .Cast<Match>()
             .Select(match => match.Value.Trim())
             .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}