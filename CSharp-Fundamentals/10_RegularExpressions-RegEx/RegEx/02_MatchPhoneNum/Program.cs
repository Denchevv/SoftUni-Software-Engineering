using System.Text.RegularExpressions;

namespace _02_MatchPhoneNum
{
    public class Program
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            foreach (string phoneNum in numbers)
            {
                Regex regex = new Regex("^[+]359(?<delimiter>[- ?])2\\1\\d{3}\\1\\d{4}\\b$");

                bool hasMatch = regex.Match(phoneNum).Success;

                if(hasMatch)
                {
                    Console.WriteLine(phoneNum + ", ");
                }
            }

                    

        }
    }
}