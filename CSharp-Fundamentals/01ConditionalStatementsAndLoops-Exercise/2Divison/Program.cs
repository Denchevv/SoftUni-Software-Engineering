int number = int.Parse(Console.ReadLine());

int divisionNum = 0;
bool notDivisible = false;

if (number % 10 == 0) { divisionNum = 10; }
else if (number % 7 == 0) { divisionNum = 7; }
else if (number % 6 == 0) { divisionNum = 6; }
else if (number % 3 == 0) { divisionNum = 3; }
else if (number % 2 == 0) { divisionNum = 2; }
else { notDivisible = true; }

if (!notDivisible)
{
    Console.WriteLine($"The number is divisible by {divisionNum}");
}
else
{
    Console.WriteLine("Not divisible");
}