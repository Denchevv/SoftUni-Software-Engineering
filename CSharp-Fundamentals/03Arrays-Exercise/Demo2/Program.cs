int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int rotations = int.Parse(Console.ReadLine());  

for (int i = 0; i < rotations; i++)
{

    int firstNum = numbers[i];

    for (int j = 0; j < numbers.Length - 1; j++)
    {
        numbers[i] = numbers[j + 1];

    }
}