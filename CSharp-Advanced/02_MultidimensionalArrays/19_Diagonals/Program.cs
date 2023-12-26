namespace _19_Diagonals
{
    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = arr;
            }

            int sumPrimary = 0;
            int sumSecondary = 0;

            for (int row = 0; row < size; row++)
            {
                sumPrimary += matrix[row][row];
                sumSecondary += matrix[row][matrix.Length-1 - row];
            }

            Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
        }
    }
}
