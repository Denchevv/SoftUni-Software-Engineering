namespace _2PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();

            }
        }
    }
}