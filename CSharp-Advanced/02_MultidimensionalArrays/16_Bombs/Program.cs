using System.Drawing;

namespace _16_Bombs
{
    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[][] field = new int[size][];

            for (int i = 0; i < size; i++)
            {
                field[i] = ReadArray();
            }

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int[] coordinates = input[i].Split(',').Select(int.Parse).ToArray();

                int row = coordinates[0];
                int col = coordinates[1];

                if (field[row][col] > 0)
                {
                    field = BombingTheField(field, row, col);

                }
            }

            var activeCells = ActiveCells(field);

            Console.WriteLine($"Alive cells: {activeCells.Count}");
            Console.WriteLine($"Sum: {activeCells.Sum()}");

            foreach (int[] arr in field)
            {
                Console.WriteLine(string.Join(" ", arr));
            }

        }
        private static List<int> ActiveCells(int[][] field)
        {
            var activeCells = new List<int>();

            foreach (int[] arr in field)
            {
                foreach (int cell in arr)
                {
                    if (cell > 0)
                    {
                        activeCells.Add(cell);
                    }
                }
            }
            return activeCells;
        }
        private static int[][] BombingTheField(int[][] field, int row, int col)
        {
            int powerOfBomb = field[row][col];
            //Reducing the values in all possible ways

            if (IsValid(field.Length, row, col) && field[row][col] > 0) // Bomb
            {
                field[row][col] = 0;
            }
            if (IsValid(field.Length, row - 1, col) && field[row - 1][col] > 0) //AboveBomb
            {
                field[row - 1][col] -= powerOfBomb;
            }
            if (IsValid(field.Length, row - 1, col - 1) && field[row - 1][col - 1] > 0) // LeftTopDiagonal
            {
                field[row - 1][col - 1] -= powerOfBomb;
            }
            if (IsValid(field.Length, row - 1, col + 1) && field[row - 1][col + 1] > 0) // RightTOpDiagonal
            {
                field[row - 1][col + 1] -= powerOfBomb;
            }
            if (IsValid(field.Length, row, col - 1) && field[row][col - 1] > 0) // LeftSide
            {
                field[row][col - 1] -= powerOfBomb;
            }
            if (IsValid(field.Length, row, col + 1) && field[row][col + 1] > 0) // RightSide
            {
                field[row][col + 1] -= powerOfBomb;
            }
            if (IsValid(field.Length, row + 1, col - 1) && field[row + 1][col - 1] > 0) // LeftBottomDiagonal
            {
                field[row + 1][col - 1] -= powerOfBomb;
            }
            if (IsValid(field.Length, row + 1, col) && field[row + 1][col] > 0) // BelowBomb
            {
                field[row + 1][col] -= powerOfBomb;
            }
            if (IsValid(field.Length, row + 1, col + 1) && field[row + 1][col + 1] > 0) // RightBottomDiagonal
            {
                field[row + 1][col + 1] -= powerOfBomb;
            }

            return field;
        }

        private static bool IsValid(int size, int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }

        private static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
