namespace _04_MatchingBrackets
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    int index = i;
                    stack.Push(index);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int lastIndex = i;
                    Console.WriteLine(input.Substring(startIndex, lastIndex - startIndex + 1));
                }
            }
        }
    }
}
