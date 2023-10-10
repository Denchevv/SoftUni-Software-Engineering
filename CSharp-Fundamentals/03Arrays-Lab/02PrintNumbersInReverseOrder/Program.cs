int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    int newNumber = int.Parse(Console.ReadLine());
    numbers[i] = newNumber;
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}