namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

            var count = new SortedDictionary<double, int> ();
            
            foreach (var number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 0;
                }
                count[number]++;    
            }

            foreach(var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}