namespace _08_TrafficJam
{
    public class Program
    {
        public static void Main()
        {
            var traffic = new Queue<string>();

            int carsPass = int.Parse(Console.ReadLine());

            int carsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    int range = traffic.Count < carsPass ? traffic.Count : carsPass;

                    for (int i = 0; i < range; i++)
                    {
                        Console.WriteLine($"{traffic.Dequeue()} passed!");
                        carsPassed++;
                    }
                    continue;
                }

                traffic.Enqueue(input);

            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
