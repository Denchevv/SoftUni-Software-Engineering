int n = int.Parse(Console.ReadLine());

int sumOdd = 0;
int sumEven = 0;

for (int i = 1; i <= n; i++)
{
    int current = int.Parse(Console.ReadLine());

    if (i % 2 != 0) {  sumOdd += current; }
    else { sumEven += current; }
}

if (sumOdd == sumEven)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumEven}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
}