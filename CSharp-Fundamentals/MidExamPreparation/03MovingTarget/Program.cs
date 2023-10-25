namespace _03MovingTarget
{
    internal class Program
    {
        static void Main()
        {
                List<int> targets = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] inputTokens = line.Split().ToArray();
                string command = inputTokens[0];
                int index = int.Parse(inputTokens[1]);
                int valuePower = int.Parse(inputTokens[2]);

                if (command == "Shoot")
                {
                    if (IsValidIndex(index, targets)) // Index exists and we are in the range of LIST => targets 
                    {
                        targets[index] -= valuePower;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets.Insert(index, valuePower);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else  // STRIKE
                {
                    if (
                      IsValidIndex(index, targets)
                      && IsValidIndex(index + valuePower, targets)
                      && IsValidIndex(index - valuePower, targets))
                    //We have to remove the index and the indexes around him - radius. We start from the RIGTHMOST
                    // because when we remove from the List it changes its indexes!!!! 
                    {
                        //right
                        for (int i = 1; i <= valuePower; i++)
                        {
                            targets.RemoveAt(index + i);
                        }
                        //index
                        targets.RemoveAt(index);
                        // left
                        for (int i = 1; i <= valuePower; i++)
                        {
                            targets.RemoveAt(index - i);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");

                    }
                }



            }
            Console.WriteLine(string.Join("|", targets));

        }
        public static bool IsValidIndex(int index, List<int> targets) // Method
        {
            return index >= 0 && index < targets.Count; // Index exists and we are in the range of LIST => targets 
        }
    }
}