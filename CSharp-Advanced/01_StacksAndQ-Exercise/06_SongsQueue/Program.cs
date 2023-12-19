namespace _06_SongsQueue
{
    public class Program
    {
        public static void Main()
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var queue = new Queue<string>(songs);

            while(queue.Count > 0)
            {
                string[] token = Console.ReadLine().Split();
                string command = token[0];

                switch(command)
                {
                    case "Play":
                        if (queue.Any())
                        {
                            queue.Dequeue();
                        }
                        break;

                    case "Add":
                        string song = string.Join(" ", token.Skip(1));
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                            continue;
                        }                    
                        queue.Enqueue(song);                       
                        break;

                    case "Show":
                        Console.WriteLine($"{string.Join(", ", queue)}");
                        break;
                }
            }

                Console.WriteLine("No more songs!");
        }
    }
}
