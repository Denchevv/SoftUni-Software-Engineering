using System;

char lastSector = char.Parse(Console.ReadLine());
int rowsFirsSector = int.Parse(Console.ReadLine());
int sitsOddRows = int.Parse(Console.ReadLine());

int counter = 0;

for (char i = 'A'; i <= lastSector; i++)
{
    for (int j = 1; j <= rowsFirsSector; j++)
    {
        if (j % 2 != 0)
        {
            for (char k = 'a'; k < 'a' + sitsOddRows; k++)
            {
                Console.WriteLine($"{i}{j}{k} ");
                counter++;
            }
        }
        else
        {
            for (char k = 'a'; k < 'a' + sitsOddRows + 2; k++)
            {
                Console.WriteLine($"{i}{j}{k} ");
                counter++;
            }
        }
    }
    rowsFirsSector++;
}
Console.WriteLine(counter);