using System.Security.Authentication;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5,6};
            int[] reversedArray = new int[numbers.Length];
            int counter = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversedArray[counter] = numbers[i];
                counter++;
            }
            
            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}