int range = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int minNum = int.MaxValue;

for (int i = 0; i < range; i++)
{
    int number = int.Parse(Console.ReadLine());

    if(number < minNum)
    {
        minNum = number;
    }
    
    if (number > maxNum)
    {
        maxNum = number; 
    }

}

Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");