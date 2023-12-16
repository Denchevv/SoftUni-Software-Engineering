int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int leftSum = 0;
int rightSum = 0;

foreach (var number in numbers)
{
    rightSum += number;
}

for (int i = 0; i < numbers.Length; i++)
{
    rightSum -= numbers[i];

    if (rightSum == leftSum)
    {
        Console.WriteLine(i);
        return;
    }

    leftSum += numbers[i];
}
Console.WriteLine("no");
