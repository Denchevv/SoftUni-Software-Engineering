int n  = int.Parse(Console.ReadLine());

int row = 1;
int column = 1;

for (int i = 1; i <= n; i++)
{
    Console.Write(i);
    if (row == column)
    {
        Console.WriteLine();
        row++;
        column = 1;
    }
    else
    {
        Console.Write(" ");
        column++;
    }

}
