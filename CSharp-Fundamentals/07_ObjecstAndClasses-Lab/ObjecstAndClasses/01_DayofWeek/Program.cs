using System.Globalization;

namespace _01_DayofWeek
{
    public class Program
    {
        public static void Main()
        {
            var stringDate = Console.ReadLine();
            DateTime date = DateTime
                .ParseExact(stringDate, "yyyy-M-d", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}