//1.Read input
double vacationPrice = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int daysCounter = 0;
int spendingDays = 0;

//2. While loop and calculation of the money
while (availableMoney < vacationPrice && spendingDays < 5)
{
    string input = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());

    daysCounter++;

    if (input == "save") { availableMoney += sum; spendingDays = 0; }
    else
    {
        spendingDays++;
        //availableMoney = Math.Max(availableMoney - sum, 0);
       availableMoney -= sum;
       if (availableMoney < 0) { availableMoney = 0; }
    }
}

//3. Print output 
if (vacationPrice > availableMoney)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(daysCounter);
}
else
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}