using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _01_MatchFullName2
{
    public class Program
    {
        public static void Main()
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();
            
            MatchCollection namesMatch = Regex.Matches(names, regex);

            foreach (Match match in namesMatch)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();

        }
    }
}