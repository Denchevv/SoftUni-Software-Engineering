namespace _13_MaxSum
{
    public class Program
    {
        public static void Main()
        {
            int[] sizes = ReadArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            FillMatrix(sizes, matrix);

            int maxSum = int.MinValue;
            int mxRow = 0;
            int mxCol = 0;

            for (int row = 0; row <= sizes[0] - 3; row++)
            {
                int currentSum = 0;
                for (int col = 0; col <= sizes[1] - 3; col++)
                {
                    int row0 = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                    int row1 = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                    int row2 = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    currentSum= row0 + row1 + row2;

                    if(currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        mxRow = row;
                        mxCol = col;

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = mxRow;  row <= mxRow+2; row++) 
            {
                for (int col = mxCol; col <= mxCol+2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void FillMatrix(int[] sizes, int[,] matrix)
        {
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] numArr = ReadArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = numArr[col];
                }
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
