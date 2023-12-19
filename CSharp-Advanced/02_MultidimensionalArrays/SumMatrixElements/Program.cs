namespace SumMatrixElements
{
    public class Program
    {
        public static void Main()
        {
           int[] sizes = NewMethod();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = NewMethod();
                for(int col = 0; col < sizes[1]; col++)
                {
                    matrix[row,col] = arr[col];
                }
            }

            int sum = 0;

            foreach(var num in matrix)
            {
                sum += num;
            }

            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sum);

        }

        private static int[] NewMethod()
        {
           return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
