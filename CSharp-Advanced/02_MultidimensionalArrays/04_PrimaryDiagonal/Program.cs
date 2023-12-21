namespace _04_PrimaryDiagonal
{
    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ReadArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int diagonalSum = 0;

            for (int row = 0;row < size; row++)
            {
                diagonalSum += matrix[row, row];
            }

                Console.WriteLine(diagonalSum);
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
