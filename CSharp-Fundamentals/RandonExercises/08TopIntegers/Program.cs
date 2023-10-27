namespace _08TopIntegers
{
    internal class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    
                    if (numbers[i]<= numbers[j])
                    {
                        break;
                    }
                    else if (j == numbers.Length-1)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}