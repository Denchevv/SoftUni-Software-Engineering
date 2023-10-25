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
                int currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int length = numbers.Length - 1;
                    if (currentNum <= numbers[j])
                    {
                        break;
                    }
                    else if (j == length)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
                
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}