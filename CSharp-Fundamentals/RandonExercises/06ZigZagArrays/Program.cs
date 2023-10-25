namespace _06ZigZagArrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstARr = new int[n];
            int[] secondARr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

                if (i % 2 == 0)
                {
                    firstARr[i] = currentArr[0];
                    secondARr[i] = currentArr[1];
                }
                else
                {
                    firstARr[i] = currentArr[1];
                    secondARr[i] = currentArr[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstARr));
            Console.WriteLine(string.Join(" ", secondARr));
        }
    }
}