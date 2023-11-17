namespace _01_CountRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            double[] inputArr = Console.ReadLine()
                           .Split()
                           .Select(double.Parse)
                           .ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var number in inputArr)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 0;
                }             

                    count[number]++;

            }

            foreach (var kvp in count) 
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}