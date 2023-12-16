namespace _02_Counter_Strike
{
    public class Program
    {
        public static void Main()
        {
            int energy = int.Parse(Console.ReadLine());

            int winsCounter = 0; 

            while (true)
            {
                string line = Console.ReadLine();
                if(line == "End of battle")
                {
                    break;
                }

                int distance = int.Parse(line);

                if(distance <= energy)
                {
                    energy -=distance;
                    winsCounter++;
                    if (winsCounter % 3 == 0)
                    {
                        energy += winsCounter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with " +
                        $"{winsCounter} won battles and {energy} energy");
                    return;
                }
            }

            Console.WriteLine($"Won battles: {winsCounter}. Energy left: {energy}");
        }
    }
}
