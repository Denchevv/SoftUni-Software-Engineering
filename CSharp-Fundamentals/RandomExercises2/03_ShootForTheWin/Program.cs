namespace _03_ShootForTheWin
{
    public class Program
    {
        public static void Main()
        {
            int[] targets = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            int shotCounter = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                int index = int.Parse(line);

                if (!(index >= 0 && index < targets.Length))
                {
                    continue;
                }

                if (targets[index] == -1)
                {
                    continue;
                }

                int currentValue = targets[index];
                targets[index] = -1;
                shotCounter++;

                // Reduce the greater values
                for (int i = 0; i < targets.Length; i++)
                {
                    int currentNum = targets[i];
                    if (currentNum > currentValue)
                    {
                        targets[i] -= currentValue;
                    }
                    // Increase the equal or smaller values
                    else if (currentNum <= currentValue && currentNum != -1)
                    {
                        targets[i] += currentValue;

                    }

                }
            }

            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ", targets)}");
        }
    }
}
