namespace _14_SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            string snakeWords = Console.ReadLine();

            Queue<char> snake = new Queue<char>(snakeWords);

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                for (int col = 0; col < sizes[1]; col++)
                {
                    if (row % 2 == 1)
                    {
                        for(int col2 = sizes[1]-1; col2 >= 0; col2--)
                        {
                            
                            matrix[row, col2] = snake.Peek();
                            snake.Enqueue(snake.Dequeue());
                        }
                        break; 
                    }
                    matrix[row, col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }

            for (int row = 0;row < sizes[0]; row++)
            {
                for(int col = 0; col< sizes[1]; col++)
                {
                    Console.Write(matrix[row, col]); 
                }
                Console.WriteLine();
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
