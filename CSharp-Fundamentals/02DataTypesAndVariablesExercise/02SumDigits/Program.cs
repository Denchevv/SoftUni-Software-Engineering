string number = Console.ReadLine();

int sum = 0;

foreach (char symbol in number)
{
    int digit = symbol - '0';

    sum += digit;
}
Console.WriteLine(sum);