namespace _03_MaximalSum
{
    public class Program
    {
        public static void Main()
        {
            int[] sizes = ReadArr();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arrayNums = ReadArr();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arrayNums[col];
                }
            }

            int mxRow = 0;
            int mxCol = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i <= sizes[0] - 3; i++)
            {
                int sum = 0;
                for (int j = 0; j <= sizes[1] - 3; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        mxRow = i;
                        mxCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = mxRow; row <= mxRow + 2; row++)
            {
                for (int col = mxCol; col <= mxCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static int[] ReadArr()
        {
            return Console.ReadLine()
                 .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
        }
    }
}
