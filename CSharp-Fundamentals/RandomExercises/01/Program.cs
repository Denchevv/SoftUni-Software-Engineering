namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numberse = new int[n];
            for (int i = 0; i < n; i++)
            {
                numberse[i] = int.Parse(Console.ReadLine());

            }

            Array.Reverse(numberse);
            Console.WriteLine(string.Join(" ", numberse));



        }
    }
}