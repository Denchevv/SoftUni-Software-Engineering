using System.Text.RegularExpressions;

namespace _02_
{
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Regex regex = new Regex("^\\|(?<name>[A-Z]{4,})\\|:#(?<position>[A-Za-z]+ [A-Za-z]+)#$");


            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string position = match.Groups["position"].Value;
                    Console.WriteLine($"{name}, The {position}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armor: {position.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}