int lettersCount = int.Parse(Console.ReadLine());



for (int i = 1; i <= lettersCount; i++)
{
    int buttonsPressed = int.Parse(Console.ReadLine());

    int length = buttonsPressed.ToString().Length;
    int mainDigit = buttonsPressed % 10;


    int offsetNumber = (mainDigit - 2) * 3;

    if (mainDigit == 8 || mainDigit == 9)
    {
        offsetNumber += 1;
    }

    int letterIndex = offsetNumber + length - 1;

   
    char symbol = (char)(97 + letterIndex);
    if (buttonsPressed == 0)
    {
        symbol = ' ';
    }

    Console.Write($"{symbol}");
}