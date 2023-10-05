int n = int.Parse(Console.ReadLine());

int sum = 0;
int max = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());    
    sum += num; 

    if (num > max)
    {
        max = num;
    }
}

int sumWithoutMax = sum - max;

if (sumWithoutMax == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumWithoutMax - max)}");
}