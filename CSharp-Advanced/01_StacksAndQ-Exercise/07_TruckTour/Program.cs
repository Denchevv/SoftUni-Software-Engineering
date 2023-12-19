namespace _07_TruckTour
{
    public class Program
    {
        public static void Main()
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] data = Console.ReadLine()
                            .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                queue.Enqueue(data);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (int[] data in queue)
                {
                    int petrol = data[0];
                    int distance = data[1];

                    totalFuel += petrol - distance;

                    if(totalFuel < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }

                if(totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);

        }
    }
}
