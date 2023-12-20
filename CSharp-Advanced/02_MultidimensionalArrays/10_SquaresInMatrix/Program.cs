
namespace _10_SquaresInMatrix
{
    public class Program
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            char[,] matrix = ReadMatrix(sizes[0], sizes[1]);
            int counter = 0;

            for (int i = 0; i < sizes[0] - 1; i++)
            {

                for (int j = 0; j < sizes[1] - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);

        }

        private static char[,] ReadMatrix(int size1, int size2)
        {
            char[,] matrix = new char[size1, size2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = ReadArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            return matrix;
        }

        public static char[] ReadArray()
        {
            return Console.ReadLine()
               .Split()
               .Select(char.Parse)
               .ToArray();
        }
    }
}
