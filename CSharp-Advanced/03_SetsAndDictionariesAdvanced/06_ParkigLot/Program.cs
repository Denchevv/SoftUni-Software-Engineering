namespace _06_ParkigLot
{
    public class Program
    {
        public static void Main()
        {
            HashSet<string> set = new HashSet<string>();

            string input;
            while((input = Console.ReadLine()) !=  "END")
            {
                string[] data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "IN")
                {
                    set.Add(data[1]);
                }
                else
                {
                    set.Remove(data[1]);
                }
            }

            if(set.Count > 0)
            {
                foreach(string data in set)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
