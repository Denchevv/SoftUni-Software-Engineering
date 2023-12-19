namespace _05_FashionBoutique
{
    public class Program
    {
        public static void Main()
        {
            int[] clothes = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothes);

            int racksUsed = 1;
            int rackCapacityLeft = rackCapacity;

            while (stack.Count > 0)
            {
                int currentNum = stack.Peek();
                if (currentNum > rackCapacityLeft)
                {
                    racksUsed++;
                    rackCapacityLeft = rackCapacity;
                }
                    int cloth = stack.Pop();
                    rackCapacityLeft -= cloth;
            }

            Console.WriteLine(racksUsed);
        }
    }
}
