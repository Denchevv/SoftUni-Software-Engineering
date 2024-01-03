

namespace _03_SnakeMoves
{
    public class Program
    {
       public static void Main()
        {
            int[] sizes = ReadArr();
            string snakeWord = Console.ReadLine();

            Queue<char> snake = new Queue<char>(snakeWord);
            char[,] matrix = new char[sizes[0], sizes[1]];
            FillMatrix(matrix, snake);
            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void FillMatrix(char[,] matrix, Queue<char>snake)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row % 2 == 1)
                    {
                        for (int col2 = matrix.GetLength(1) - 1;col2 >= 0 ; col2--)
                        {
                            matrix[row,col2] = snake.Peek();
                            snake.Enqueue(snake.Dequeue());
                        }
                        break;
                    }

                    matrix[row, col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }
        }

        public static int[] ReadArr()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
