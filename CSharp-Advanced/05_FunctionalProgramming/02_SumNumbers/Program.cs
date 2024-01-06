﻿namespace _02_SumNumbers
{
    public class Program
    {
        public static void Main()
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
