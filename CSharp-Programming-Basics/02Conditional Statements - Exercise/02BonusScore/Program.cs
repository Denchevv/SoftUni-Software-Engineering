int number = int.Parse(Console.ReadLine());

double sumPoints = 0.0;

if (number <= 100)
{
    sumPoints = +5;
}
else if (number <= 1000)
{
    sumPoints = number * 0.2;
}
else if (number > 1000)
{
    sumPoints = number * 0.1;
}

if (number % 2 == 0)
{
    sumPoints += 1;
}

if (number % 10 == 5)
{
    sumPoints += 2;
}

Console.WriteLine($"{sumPoints}");
Console.WriteLine($"{sumPoints + number}");