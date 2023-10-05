int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    int evenSum = 0, oddSum = 0;
    bool isEven = false;
    int currentNum = i;

    while(currentNum != 0)
    {
        int lastDigit = currentNum % 10;

        if (isEven) { evenSum += lastDigit; }
        else { oddSum += lastDigit; }

        isEven = !isEven;
        currentNum = currentNum / 10;
    }

    if (evenSum == oddSum)
    {
        Console.Write($"{i} ");
    }


}