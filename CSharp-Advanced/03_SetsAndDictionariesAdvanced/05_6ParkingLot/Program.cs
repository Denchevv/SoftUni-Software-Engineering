namespace _05_6ParkingLot
{
    public class Program
    {
        public static void Main()
        {
            string line;
            while((line = Console.ReadLine()) != "END") 
            {
                string[] tokens = line.Split(",", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string number = tokens[1];

                if (command == "IN")
                {

                }
                else
                {

                }
            }
        }
    }
}
