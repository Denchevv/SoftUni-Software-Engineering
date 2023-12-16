int pokePower = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

int originalPower = pokePower;
int targetsPoked = 0;

while (pokePower >= distance)
{
    pokePower -= distance;
    targetsPoked++;

    if (pokePower == originalPower / 2 && exhaustionFactor > 0)
    {
        pokePower /= exhaustionFactor;
    }
}

Console.WriteLine(pokePower);
Console.WriteLine(targetsPoked);