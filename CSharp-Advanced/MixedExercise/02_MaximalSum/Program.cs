namespace _02_MaximalSum
{
    public class Program
    {
        public static void Main()
        {
            int[] dimensions = ReadArr();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            FillMatrix(matrix);

            int maxSum = 0;
            int rowIndexResult = -1;
            int colIndexResult = -1;

            int rowRange = matrix.GetLength(0) - 3;
            for (int row = 0; row <= rowRange; row++)
            {
                int currentSum = 0;

                int colRange = matrix.GetLength(1) - 3;
                for (int col = 0; col <= colRange; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndexResult = row;
                        colIndexResult = col;
                    }
                }
            }

            PrintResult(rowIndexResult, colIndexResult, maxSum, matrix);

        }
        public static void PrintResult(int rowIndexResult, int colIndexResult, int maxSum, int[,] matrix)
        {
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = rowIndexResult; row < rowIndexResult + 3; row++)
            {
                for (int col = colIndexResult; col < colIndexResult + 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[] ReadArr()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
        public static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
