//1. Read input
double priceOver20kg = double.Parse(Console.ReadLine());
double luggageKG = double.Parse(Console.ReadLine());
int daysLeft = int.Parse(Console.ReadLine());
int quantityLugages = int.Parse(Console.ReadLine());

//2. Make calculations
double price = 0;
if (luggageKG < 10) { price = priceOver20kg * 0.2; }
else if (luggageKG <= 20) { price = priceOver20kg * 0.5; }
else if (luggageKG > 20) { price = priceOver20kg; }

if (daysLeft > 30) { price *= 1.1; }
else if (daysLeft <= 30 && daysLeft >= 7) { price *= 1.15; }
else if (daysLeft < 7) { price *= 1.4; }

//3. Print output
Console.WriteLine($"The total price of bags is: {price * quantityLugages:f2} lv.");