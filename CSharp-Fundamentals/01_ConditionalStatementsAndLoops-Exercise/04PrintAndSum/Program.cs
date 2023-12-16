int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = n1; i <= n2; i++)
{
    sum += i;
    Console.Write($"{i} ");
}
Console.WriteLine($"\nSum: {sum}");