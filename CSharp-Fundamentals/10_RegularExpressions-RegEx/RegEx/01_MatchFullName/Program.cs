using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _01_MatchFullName
{
    public class Program
    {
        public static void Main()
        {
            string[] names = Console.ReadLine()
                             .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

            foreach (string name in names)
            {
                Regex regex = new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$");

                bool hasMatch = regex.Match(name).Success;

                if (hasMatch)
                {
                    Console.Write(name + " ");
                }
            }

        }
    }
}
//                              Second Solution: 
/* string regex = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach(Match name in matchedNames)
            {
                Console.Write(name.Value + " ");    
            }
            Console.WriteLine();
*/


/* Functional Programming Solution:

Console.WriteLine(string.Join(" ",
    Console.ReadLine().Split(", ",
        StringSplitOptions.RemoveEmptyEntries)
        .Where(x => new Regex("^[A-Z][a-z]+ [A-Z][a-z]+$")
        .Match(x)
        .Success)));
 */