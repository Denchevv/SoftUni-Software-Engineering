namespace _01_Train
{
    internal class Program
    {
        public static void Main()
        {
            List<int> wagonsList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {

                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] token = line.Split();

                string command = token[0];
                if (command == "Add")
                {
                    int passengers = int.Parse(token[1]);

                    wagonsList.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(token[0]);

                    wagonsList = FindingSeatsForPassengers(wagonsList, passengers, capacity);
                }
            }
            Console.WriteLine(string.Join(" ", wagonsList));

        }

        public static List<int> FindingSeatsForPassengers(List<int> wagonsList, int passengers, int capacity)
        {
            for (int i = 0; i < wagonsList.Count; i++)
            {
                if (wagonsList[i] + passengers <= capacity)
                {
                    wagonsList[i] += passengers;
                    break;
                }
            }
            return wagonsList;
        }
    }
}