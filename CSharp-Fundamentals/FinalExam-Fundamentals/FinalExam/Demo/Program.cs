using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < range; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                int inDigits = symbol;

                sum += inDigits;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
       
    }
}