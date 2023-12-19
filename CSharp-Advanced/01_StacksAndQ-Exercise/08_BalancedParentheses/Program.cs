
using System.Threading.Channels;

namespace _08_BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>();

            if(input == null)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0;i < input.Length;i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    
                    stack.Push(input[i]);
                }
                else
                {
                    char currentSymbol = '0';
                    if (stack.Any())
                    {
                        currentSymbol = stack.Pop();
                    }
                    char opositeSymbol = OpositeParenthesis(currentSymbol);

                    if (input[i] != opositeSymbol)
                    {
                        Console.WriteLine("NO");
                        return;
                    }                  
                }
            }

            Console.WriteLine("YES");
        }

        private static char OpositeParenthesis(char currentSymbol)
        {
            if(currentSymbol == '(') 
            {
                return ')';
            }
            else if(currentSymbol == '{')
            {
                return '}';
            }
            else if(currentSymbol == '[')
            {
                return ']';
            }

            return currentSymbol;
        }
    }
}
