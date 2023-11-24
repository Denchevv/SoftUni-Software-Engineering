using System.Diagnostics.Metrics;
using System.Net.Sockets;

namespace _18_WinningTicket
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            char winningSymbol1 = '0';
            char winningSymbol2 = '0';

            int longestSeq1 = 0;
            int longestSeq2 = 0;


            for (int i = 0; i < input.Length; i++)
            {
                string currentTicket = input[i];
                int counterOne = 1;
                int counterTwo = 1;

                bool isValid = IsItValid(currentTicket);
                if (isValid)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        char currectSymb = currentTicket[j];
                        char currectSymb2 = currentTicket[j + 1];

                        bool correctSymbols = ContainsOnlyTheseFourSymbols(currectSymb);

                        if (currectSymb == currectSymb2 && correctSymbols)
                        {
                            counterOne++;

                            if (counterOne > longestSeq1)
                            {
                                longestSeq1 = counterOne;
                                winningSymbol1 = currectSymb;
                            }
                            continue;
                        }
                        counterOne = 1;
                    }

                    for (int j = 10; j < 19; j++)
                    {
                        char currectSymb = currentTicket[j];
                        char currectSymb2 = currentTicket[j + 1];

                        bool correctSymbols = ContainsOnlyTheseFourSymbols(currectSymb);

                        if (currectSymb == currectSymb2 && correctSymbols)
                        {

                            counterTwo++;

                            if (counterTwo > longestSeq2)
                            {
                                longestSeq2 = counterTwo;
                                winningSymbol2 = currectSymb;
                            }

                            continue;
                        }
                        counterTwo = 1;
                    }

                    if (longestSeq1 >= 6 && longestSeq2  >= 6 && winningSymbol1 == winningSymbol2)
                    {
                        if (longestSeq1 == longestSeq2)
                        {
                            if (longestSeq1 >= 6 && longestSeq1 <= 9)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {longestSeq1}{winningSymbol1}");
                            }
                            else if (longestSeq1 == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {longestSeq1}{winningSymbol1} Jackpot!");
                            }
                        }
                        else
                        {
                            int shorterSeq = Math.Min(longestSeq1, longestSeq2);
                            Console.WriteLine($"ticket \"{currentTicket}\" - {shorterSeq}{winningSymbol1}");

                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

                longestSeq1 = 0;
                longestSeq2 = 0;

            }
        }

        public static bool ContainsOnlyTheseFourSymbols(char symbol)
        {
            char[] chars = { '@', '#', '$', '^' };

            if (chars.Contains(symbol))
            {
                return true;
            }
            return false;


        }
        public static bool IsItValid(string ticket)
        {
            if (ticket.Length == 20)
            {
                return true;
            }
            return false;
        }
    }
}