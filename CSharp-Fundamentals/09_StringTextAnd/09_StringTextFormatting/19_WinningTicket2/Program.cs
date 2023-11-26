namespace _19_WinningTicket2
{
    // Cash$$$$$$Ca$$$$$$sh
    // Check solution again missing something 
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if(ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }

                string firstTen = ticket.Substring(0, 10);
                string secondTen = ticket.Substring(10);

                int length = 0;
                char symbol = ' ';

                for (int j = 6; j < 10; j++) 
                {
                    if(firstTen.Contains(new string('@', i)) && secondTen.Contains(new string('@', i)))
                    {
                        length = i;
                        symbol = '@';
                    }
                    if (firstTen.Contains(new string('$', i)) && secondTen.Contains(new string('$', i)))
                    {
                        length = i;
                        symbol = '$';
                    }
                    if (firstTen.Contains(new string('#', i)) && secondTen.Contains(new string('#', i)))
                    {
                        length = i;
                        symbol = '#';
                    }
                    if (firstTen.Contains(new string('^', i)) && secondTen.Contains(new string('^', i)))
                    {
                        length = i;
                        symbol = '^';
                    }
                }

                if(length < 6)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }
                else if(length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {length} {symbol} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {length} {symbol}");

                }

            }


        }
    }
}