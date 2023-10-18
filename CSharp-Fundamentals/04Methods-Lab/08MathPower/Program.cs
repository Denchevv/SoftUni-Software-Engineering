double number = double.Parse(Console.ReadLine());

double power = double.Parse(Console.ReadLine());
Console.WriteLine(GetPowerOfNumber(number, power));

static double GetPowerOfNumber (double number, double power)
{
    double result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}