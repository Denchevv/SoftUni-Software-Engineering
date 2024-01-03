

namespace _01_DiagonalDifference
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            FillMatrix(matrix, n);

            int diagonalDiff = GetDiagonalDiff(matrix);
            Console.WriteLine(Math.Abs(diagonalDiff));
        }

        static int GetDiagonalDiff(int[,] matrix)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                    firstDiagonal += matrix[row,row];
                    secondDiagonal += matrix[row,matrix.GetLength(1) - 1 - row];           
            }

            return firstDiagonal - secondDiagonal;
        }

        static void FillMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for(int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
