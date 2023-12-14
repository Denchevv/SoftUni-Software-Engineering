int lines = int.Parse(Console.ReadLine());
long[] previousRow = new long[lines];
long[] currentRow = new long[lines];
previousRow[0] = 1; //Startup row is always equal to "1"
Console.WriteLine(previousRow[0]);
for (int r = 1; r < lines; r++)
{
    for (int c = 0; c <= r; c++)
    {
        if (c == 0)
        {
            currentRow[c] = 0 + previousRow[c]; //Empty entries are treated as equal to "0"
        }
        else
        {    
            currentRow[c] = previousRow[c - 1] + previousRow[c];
        }
        Console.Write($"{currentRow[c]} ");
    }
    for (int j = 0; j < lines; j++)
    {
        previousRow[j] = currentRow[j];
    }
    Console.WriteLine();
}