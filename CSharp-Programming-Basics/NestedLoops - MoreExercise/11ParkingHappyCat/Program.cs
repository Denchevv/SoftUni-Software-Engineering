int daysOnTheParking = int.Parse(Console.ReadLine());
int hoursOnTheParking = int.Parse(Console.ReadLine());

//2. For loop - condition and calculations
double totalMoney =  0;

for (int days = 1; days <= daysOnTheParking; days++)
{
    double parkingTax = 0;
    for (int hours = 1; hours <= hoursOnTheParking; hours++)
    {
        if (days % 2 == 0 & hours % 2 != 0)
        {
            parkingTax += 2.50;
        }
        else if (days % 2 != 0 && hours % 2 == 0)
        {
            parkingTax += 1.25;
        }
        else
        {
            parkingTax += 1;
        }

    }
    Console.WriteLine($"Day: {days} - {parkingTax:f2} leva");
    totalMoney += parkingTax;
}
Console.WriteLine($"Total: {totalMoney:f2} leva");