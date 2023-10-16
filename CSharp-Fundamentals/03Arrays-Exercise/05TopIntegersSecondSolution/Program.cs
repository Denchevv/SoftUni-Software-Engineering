int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int firstNumber = numbers[i];

    for (int j = i + 1; j < numbers.Length; j++)
    {
        int secondNumber = numbers[j];
        
        if (firstNumber <= secondNumber)
        {
            break;
        }
        else if (j == numbers.Length - 1)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
}
Console.WriteLine(numbers[numbers.Length - 1]);