
namespace _16_KnightGame
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = symbols[col];
                }
            }

            int removedKnights = CountOfRemovedKnights(board, n);
            Console.WriteLine(removedKnights);
        }

        private static int CountOfRemovedKnights(char[,] board, int n)
        {
            int count = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (board[row, col] == 'K')
                    {
                        if (IsInDanger(board, row - 1, col + 2, n) ||
                            IsInDanger(board, row - 1, col - 2, n) ||
                            IsInDanger(board, row + 1, col + 2, n) ||
                            IsInDanger(board, row + 1, col - 2, n) ||
                            IsInDanger(board, row - 2, col + 1, n) ||
                            IsInDanger(board, row - 2, col - 1, n) ||
                            IsInDanger(board, row + 2, col + 1, n) ||
                            IsInDanger(board, row + 2, col - 1, n))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
        public static bool IsInDanger(char[,] board, int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n && board[row, col] == 'K';
        }
    }
}