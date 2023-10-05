int budget = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();    
int countFishermans = int.Parse(Console.ReadLine());

double totalPrice = 0;
double discount = 1.0;

if (countFishermans <= 6) { discount = 0.9; }
else if (countFishermans >= 7 && countFishermans <= 11) { discount = 0.85; }
else if (countFishermans > 12) { discount = 0.75; }


if (season == "Spring") { totalPrice = 3000 * discount; }
else if (season == "Summer" || (season == "Autumn")) { totalPrice = 4200 * discount; }
else if (season == "Winter") { totalPrice = 2600 * discount; }


if (countFishermans % 2 == 0 && season != "Autumn") { totalPrice = totalPrice * 0.95;}


if (budget >= totalPrice)
{
    Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
}