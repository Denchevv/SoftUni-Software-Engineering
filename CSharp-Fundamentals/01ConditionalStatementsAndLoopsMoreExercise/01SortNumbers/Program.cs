double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());

if (num1 < num2)
{
    double temp = num1;
    num1 = num2;
    num2 = temp;
}
if (num2 < num3)
{
    double temp = num2;
    num2 = num3;
    num3 = temp;
}
if (num1 < num2)
{
    double temp = num1;
    num1 = num2;
    num2 = temp;
}


Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);