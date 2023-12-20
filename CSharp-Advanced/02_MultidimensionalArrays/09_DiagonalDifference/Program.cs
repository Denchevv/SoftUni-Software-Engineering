namespace _09_DiagonalDifference
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                int[] arr = ReadArr();
                for(int col = 0; col < n; col++)
                {
                    matrix[row,col] = arr[col];
                }
            }
            
            for(int row = 0;row < n; row++)
            {
                sumFirstDiagonal += matrix[row, row];
                int index = n - row - 1;
                sumSecondDiagonal += matrix[row, index];
            }

            int result = Math.Abs(sumSecondDiagonal - sumFirstDiagonal);

            Console.WriteLine(result);
        }
        private static int[] ReadArr()
        {
            return Console.ReadLine()
                 .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
        }
    }
}
