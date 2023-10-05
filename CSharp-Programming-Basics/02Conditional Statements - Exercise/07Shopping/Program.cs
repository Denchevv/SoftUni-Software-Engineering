double budget = double.Parse(Console.ReadLine());
int videocardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());   
int rammMemmoriesCount = int.Parse(Console.ReadLine());

double videoCost = videocardsCount * 250;
double processorsPrice = videoCost * 0.35 * processorsCount;
double rammPrice = videoCost * 0.1 * rammMemmoriesCount;

double totalPrice = videoCost + processorsPrice + rammPrice;

if (videocardsCount > processorsCount)
{
    totalPrice = totalPrice * 0.85;
}

if (totalPrice <= budget)
{
    Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
}
else 
{
    Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
}