string number = Console.ReadLine();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    int factoriel = 1;

    int currentDigit = int.Parse(number[i].ToString());

    for (int j = 1; j <= currentDigit; j++)
    {
        factoriel *= j;
    }
    sum += factoriel;
}

if (sum == int.Parse(number))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}