namespace _05_SymbolnMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] symbols = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    symbols[row, col] = input[col];
                  
                }
            }

            char wantedSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {             
                for (int col = 0; col < n; col++)
                {
                    if (symbols[row, col] == wantedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{wantedSymbol} does not occur in the matrix");
        }
    }
}
