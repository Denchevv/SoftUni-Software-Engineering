namespace _12_MatrixShuffling
{
    public class Program
    {
        public static void Main()
        {
            int[] sizes = ReadArr();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                string[] strArr = Console.ReadLine().Split();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = strArr[col];
                }
            }

            string input;
            while((input = Console.ReadLine().ToUpper()) != "END") 
            {
                string[] tokens = input.Split();

                string command = tokens[0];
                if (tokens.Length == 5 && command == "SWAP")
                {
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);

                    //if (row1 >= matrix.GetLength(0) || row1 < 0 || col1 >= matrix.GetLength(1) || col1 < 0 ||
                    //    row2 >= matrix.GetLength(0) || row2 < 0 || col2 >= matrix.GetLength(1) || col2 < 0)
                    //{
                    //    Console.WriteLine("Invalid input!");
                    //    continue;
                    //}
                    if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col2 < matrix.GetLength(1) &&
                        row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }

                        continue;
                    }
                }
                        Console.WriteLine("Invalid input!");
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
