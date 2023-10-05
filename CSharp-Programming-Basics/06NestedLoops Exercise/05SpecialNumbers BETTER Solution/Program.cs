int n  = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{
    int currentNumer = i;
    bool isMagic = true;

    while (currentNumer != 0)
    {
        int lastDigit = currentNumer % 10;

        if (lastDigit == 0 || n % lastDigit != 0)
        {
            isMagic = false;
            break;
        }
        currentNumer /= 10;
    }

    if (isMagic)
    {
        Console.Write($"{i} ");
    }
}