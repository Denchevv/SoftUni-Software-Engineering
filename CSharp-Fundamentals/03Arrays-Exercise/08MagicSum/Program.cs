int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

int magixSum = int.Parse(Console.ReadLine());

int[] magicArray = new int[2];
int sum = 0;

for (int i = 0; i < numbers.Length-1; i++)
{
    int firstNum = numbers[i];
    for (int j = i + 1; j < numbers.Length; j++)
    {
        int secondNum = numbers[j];
        if (firstNum + secondNum == magixSum)
        {
            magicArray[0] = numbers[i];
            magicArray[1] = numbers[j];

            Console.WriteLine(string.Join(" ", magicArray));
        }
    }
}