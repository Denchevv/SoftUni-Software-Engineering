namespace _05_HotPatato
{
    public class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                    .Split()
                    .ToArray();
            int tosses = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
