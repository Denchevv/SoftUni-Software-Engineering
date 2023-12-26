
namespace _17_Miner
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();

            char[][] field = new char[size][];

            for (int i = 0; i < size; i++)
            {
                field[i] = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();
            }

            int[] coordinates = GetStartPosition(field);
            int row = coordinates[0];
            int col = coordinates[1];

            for (int i = 0; i < commands.Length; i++)
            {
                int currentRow = -1;
                int currentCol = -1;

                string command = commands[i];

                if (command == "up")
                {
                    currentRow = row - 1;
                    currentCol = col;
                }
                else if (command == "down")
                {
                    currentRow = row + 1;
                    currentCol = col;
                }
                else if (command == "left")
                {
                    currentRow = row;
                    currentCol = col - 1;
                }
                else if (command == "right")
                {
                    currentRow = row;
                    currentCol = col + 1;
                }

                if (IsInField(field, currentRow, currentCol))
                {
                    row = currentRow;
                    col = currentCol;

                    switch (field[currentRow][currentCol])
                    {
                        case 'c':
                            field[currentRow][currentCol] = '*';
                            break;

                        case 'e':
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            break;

                    }
                }
            }

                int coalsNum = field.SelectMany(row => row).Count(symbol => symbol == 'c');

                Console.WriteLine(coalsNum == 0
                    ? $"You collected all coals! ({row}, {col})"
                    : $"{coalsNum} coals left. ({row}, {col})"); 
        }

        private static bool IsInField(char[][] field, int row, int col)
        {
            return row >= 0 && row < field.Length && col >= 0 && col < field.Length;

        }

        private static int[] GetStartPosition(char[][] field)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field.Length; col++)
                {
                    if (field[row][col] == 's')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }
            return coordinates;
        }
    }
}
