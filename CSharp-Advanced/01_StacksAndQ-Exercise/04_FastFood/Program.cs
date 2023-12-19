namespace _04_FastFood
{
    public class Program
    {
        public static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            var queue = new Queue<int>(orders);

            for (int i = 0; i < orders.Length; i++)
            {
                if (queue.Peek() <= foodQuantity)
                {
                    int doneOrder = queue.Dequeue();
                    foodQuantity -= doneOrder;
                    continue;
                }

                break;
            }

            Console.WriteLine(orders.Max());

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
