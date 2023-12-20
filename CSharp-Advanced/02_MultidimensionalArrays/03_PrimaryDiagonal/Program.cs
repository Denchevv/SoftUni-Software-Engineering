
namespace _03_PrimaryDiagonal
{
    public class Program
    {
        public static void Main()
        {
            int[] sizes = ReadArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int maxSum = int.MinValue;
            int mxRow = 0;
            int mxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        mxRow = row;
                        mxCol = col;
                    }
                }
            }


            Console.WriteLine($"{matrix[mxRow, mxCol]} {matrix[mxRow, mxCol+1]}");
            Console.WriteLine($"{matrix[mxRow+1, mxCol]} {matrix[mxRow+1, mxCol+1]}");
            Console.WriteLine(maxSum);


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
