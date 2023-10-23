namespace _02RoundingNumbers
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                               .Split()
                               .Select(double.Parse)
                               .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {number}");
            }

        }
    }
}