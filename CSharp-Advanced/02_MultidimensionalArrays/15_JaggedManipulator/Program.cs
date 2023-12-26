namespace _15_JaggedManipulator
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] colArr = ReadArray();

                jagged[i] = colArr;
            }

            for (int i = 0; i < jagged.Length - 1; i++)
            {

                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int col = 0; col <= jagged[i].Length - 1; col++)
                    {
                        jagged[i][col] *= 2;
                        jagged[i + 1][col] *= 2;
                    }
                }
                else
                {
                    int length = Math.Max(jagged[i].Length, jagged[i + 1].Length);

                    for (int col = 0; col <= length; col++)
                    {
                        if (col < jagged[i].Length)
                        {
                            jagged[i][col] /= 2;
                        }

                        if (col < jagged[i + 1].Length)
                        {
                            jagged[i + 1][col] /= 2;
                        }
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine().ToUpper()) != "END")
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                bool validData = (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length);

                if (command == "ADD")
                {
                    if (validData)
                    {
                        jagged[row][col] += value;
                    }
                }
                else
                {
                    if (validData)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            foreach (int[] arr in jagged)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }
        private static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
