namespace _03_MaxMinElement
{
    public class Program
    {

        static void Main()
        {
            int numberCommands = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < numberCommands; i++)
            {
                string[] token = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (token[0])
                {
                    case "1":
                        stack.Push(int.Parse(token[1]));
                        break;
                    case "2":
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4":
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.Write(string.Join(", ", stack));

        }
    }
}

