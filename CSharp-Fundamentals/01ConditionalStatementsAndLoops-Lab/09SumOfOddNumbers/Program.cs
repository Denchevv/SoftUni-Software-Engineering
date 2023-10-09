int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= n; i++)
{
    int currentOddNum = i * 2 - 1; // Logic For next odd number
    Console.WriteLine(currentOddNum);
    sum += currentOddNum;
}
Console.WriteLine($"Sum: {sum}");