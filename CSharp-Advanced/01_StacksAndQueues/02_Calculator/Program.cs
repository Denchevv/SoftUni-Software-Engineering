namespace _02_Calculator
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Reverse()
                            .ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string op = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (op == "+")
                {
                   int result = firstNum + secondNum;
                   stack.Push(result.ToString());
                }
                else
                {
                    int result = firstNum - secondNum;
                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
