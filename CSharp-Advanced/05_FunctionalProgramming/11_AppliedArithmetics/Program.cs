namespace _11_AppliedArithmetics
{
    public class Program
    {
        public static void Main()
        {
            Func<int[], int[]> add = arr => arr.Select(n => n + 1).ToArray();
            Func<int[], int[]> subtract = arr => arr.Select(n => n - 1).ToArray();
            Func<int[], int[]> multiply = arr => arr.Select(n => n * 2).ToArray();
            Action<int[]> print = number => Console.WriteLine(string.Join(" ", number));

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "add":
                       numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                    case "end":
                        return;
                }
            }


        }
    }
}
