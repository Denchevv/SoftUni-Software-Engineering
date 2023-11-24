using System.Text;

namespace _05_DigitsLettersSymb
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var symb in input)
            {
                if (char.IsLetter(symb))
                {
                    letters.Append(symb);
                }
                else if(char.IsDigit(symb))
                {
                    digits.Append(symb);
                }
                else
                {
                    others.Append(symb);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}