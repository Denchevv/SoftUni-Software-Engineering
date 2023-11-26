using System.Text.RegularExpressions;

namespace _04_MatchDates
{
    public class Program
    {
        public static void Main()
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z][a-z])\1(?<year>\d{4})\b";

            var dates = Console.ReadLine();

            var matchDates = Regex.Matches(dates, regex);   

            foreach (Match date in matchDates )
            {
                var day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

         }
    }
}