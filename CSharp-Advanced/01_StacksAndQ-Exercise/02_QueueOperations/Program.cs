

namespace _02_QueueOperations
{
    public class Program
    {
        public static void Main()
        {
            int[] firstNums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int count = firstNums[0];
            int numsToDeque = firstNums[1];
            int wantedNum = firstNums[2];

            int[] numbersArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            var queue = new Queue<int>(numbersArray);
            Dequeue(queue, numsToDeque);
            CheckForNumber(queue, wantedNum);
        }

        private static void CheckForNumber(Queue<int> queue, int wantedNum)
        {
            if(queue.Any())
            {
                if (queue.Contains(wantedNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void Dequeue(Queue<int> queue, int numsToDeque)
        {
            for (int i = 0; i < numsToDeque; i++)
            {
                queue.Dequeue();
            }         
        }
    }
}
