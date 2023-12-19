namespace _07_Supermarket
{
    public class Program
    {
        public static void Main()
        {

            Queue<string> customers = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
