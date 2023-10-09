int linesNumber = int.Parse(Console.ReadLine());

int capacity = 255;
int filledWater = 0;

for (int i = 1; i <= linesNumber; i++)
{
    int liters = int.Parse(Console.ReadLine());


    if (filledWater + liters > capacity)
    {
        Console.WriteLine("Insufficient capacity!");

    }
    else
    {
        filledWater += liters;
    }

}
Console.WriteLine($"{filledWater}");