namespace _20_RadioactiveMutant
{
    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            matrix = ReadMatrix(matrix);

            string commands = Console.ReadLine();

            bool hasWon = false;
            bool hitABunny = false;

            int[] coordinates = PlayerPosition(matrix);
            int row = coordinates[0];
            int col = coordinates[1];

            foreach (char command in commands)
            {
                int currentRow = row;
                int currentCol = col;

                switch (command)
                {
                    case 'U':
                        currentRow--;
                        currentCol = col;
                        break;
                    case 'D':
                        currentRow++;
                        currentCol = col;
                        break;
                    case 'L':
                        currentRow = row;
                        currentCol--;
                        break;
                    case 'R':
                        currentRow = row;
                        currentCol++;
                        break;
                }


                if (IsValid(matrix, currentRow, currentCol))
                {
                    if (matrix[currentRow, currentCol] == 'B')
                    {
                        hitABunny = true;
                    }
                    row = currentRow;
                    col = currentCol;

                }
                else
                {
                    hasWon = true;

                }

                List<int[]> bunniesPositions = GetBunniesPositions(matrix);

                matrix = BunnySpread(bunniesPositions, matrix);

                if (matrix[row, col] == 'B')
                {
                    hitABunny = true;
                }

                if (hasWon || hitABunny)
                {
                    break;
                }
            }

            PrintMatrix(matrix);

            if (hasWon)
            {
                Console.WriteLine($"won: {row} {col}");
            }
            else
            {
                Console.WriteLine($"dead: {row} {col}");
            }
        }

        private static List<int[]> GetBunniesPositions(char[,] matrix)
        {
            var bunniesPositions = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesPositions.Add(new[] { row, col });
                    }
                }
            }

            return bunniesPositions;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        matrix[row, col] = '.';
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(char[,] matrix, int currentRow, int currentCol)
        {
            return currentRow >= 0 && currentRow < matrix.GetLength(0)
                && currentCol >= 0 && currentCol < matrix.GetLength(1);
        }

        private static char[,] BunnySpread(List<int[]> bunniesPositions, char[,] matrix)
        {
            foreach (var position in bunniesPositions)
            {
                int row = position[0];
                int col = position[1];

                // Left
                if (IsValid(matrix, row, col - 1))
                {
                    matrix[row, col - 1] = 'B';
                }   // Right
                if (IsValid(matrix, row, col + 1))
                {
                    matrix[row, col + 1] = 'B';
                }   // Above
                if (IsValid(matrix, row - 1, col))
                {
                    matrix[row - 1, col] = 'B';
                }   // Below
                if (IsValid(matrix, row + 1, col))
                {
                    matrix[row + 1, col] = 'B';
                }

            }
            return matrix;
        }

        private static int[] PlayerPosition(char[,] matrix)
        {
            int[] coordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }

            return coordinates;
        }

        private static char[,] ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (char)line[col];
                }
            }

            return matrix;
        }
    }
}
