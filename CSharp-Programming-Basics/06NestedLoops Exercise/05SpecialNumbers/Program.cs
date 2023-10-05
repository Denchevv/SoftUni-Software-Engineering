int n = int.Parse(Console.ReadLine());


//2. Logic for finding the special number: 
for (int i = 1111; i <= 9999; i++)
{
    int currentNumber = i;
    int counter = 0;
    bool isMagic = false;
    string printingText = "";

    while (currentNumber > 0)
    {
       int lastDigit = currentNumber % 10;
       
        if (n % lastDigit == 0)
        {
            counter++;
        }
        printingText = printingText + lastDigit.ToString();

        if (counter == 4)
        {
            isMagic = true;
        }

        currentNumber /= 10;
    }
    if (isMagic)
    {
        Console.Write($"{printingText} ");
    }
}