namespace _02TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();
            int wagonCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentWagon = wagons[i];

                if (currentWagon < wagonCapacity) // 2
                {
                    int emptySeats = 4 - wagons[i];
                    people -= emptySeats; // 15 - 2 = 13

                    if (people < 0)
                    {
                        wagons[i] = wagonCapacity - Math.Abs(people);
                        Console.WriteLine("The lift has empty spots!");
                        PrintWagons(wagons);
                        return;
                    }

                    wagons[i] = 4;
                }
            }
            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            PrintWagons(wagons);

        }

        private static void PrintWagons(int[] wagons)
        {
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}