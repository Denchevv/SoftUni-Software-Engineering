using System.Collections.Generic;

namespace _01_ReversedString
{
    public class Program
    {
        public static void Main()
        {
            Stack<char> charStack = new Stack<char>();
            string input = Console.ReadLine();

            for (int i = 0;i < input.Length;i++)
            {
                charStack.Push(input[i]);
            }

            while(charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
