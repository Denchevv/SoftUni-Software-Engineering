//1. Enter values
using System.Xml.Schema;

double budget = double.Parse(Console.ReadLine());
int actorsNum = int.Parse(Console.ReadLine());  
double outfitPrice =  double.Parse(Console.ReadLine());

//2. Calculations
double decorPrice = budget * 0.1;

if (actorsNum > 150)
{
    outfitPrice = outfitPrice * 0.9;
}
double totalMoneyNeeded = outfitPrice * actorsNum + decorPrice;

if (totalMoneyNeeded > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalMoneyNeeded - budget:f2} leva more.");
} 
else if (budget >= totalMoneyNeeded)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - totalMoneyNeeded:f2} leva left.");
}

