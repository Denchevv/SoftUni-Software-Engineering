namespace _03_StackSum
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0].ToLower();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);

                }
                else if (command == "remove")
                {
                    int countToRemove = int.Parse(input[1]);

                    if (countToRemove <= stack.Count)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }


            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
