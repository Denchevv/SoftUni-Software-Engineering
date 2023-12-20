namespace _08_PascalTriangle
{
    public class Program
    {
        public static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];

            for (int i = 0; i < height; i++)
            {
                long[] row = new long[i + 1]; // Initializing new array for every row with size i+1 
                row[0] = 1;                   // Set the first col always 1 
                row[i] = 1;                   // Set the last col always to be 1

                for (int j = 1; j < i; j++) // Filling the row array
                {
                    row[j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }

                triangle[i] = row; // Filling the jagged array
            }

            for (int i = 0;i < height; i++)
            {
                Console.WriteLine(string.Join(' ', triangle[i]));
            }
        }
    }
}
