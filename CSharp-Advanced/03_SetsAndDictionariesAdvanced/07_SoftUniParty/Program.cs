namespace _07_SoftUniParty
{
    public class Program
    {
        public static void Main()
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            bool isPartyTime = false;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if(input == "PARTY") 
                {
                    isPartyTime = true;
                }

                if (isPartyTime)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipGuests.Remove(input);
                    }
                    else
                    {
                        regularGuests.Remove(input);
                    }
                }
                else
                {
                    if (char.IsDigit(input[0]))
                    {
                        vipGuests.Add(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach(string vip in vipGuests)
            {
                Console.WriteLine(vip);
            }

            foreach(string regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
