int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int counterSequence = 1;
int longestSequence = 0;
int index = 0;

for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        counterSequence++;
    }
    else
    {
        counterSequence = 1;
    }
    if (counterSequence > longestSequence)
    {
        longestSequence = counterSequence;
        index = numbers[i];
    }

}
for (int i = 0; i < longestSequence; i++)
{
    Console.Write($"{index} ");
}