string flower = Console.ReadLine();
int flowersNumber = int.Parse(Console.ReadLine());
int budget =  int.Parse(Console.ReadLine());

double pricePerFlower = 0;

if (flower == "Roses")
{
    pricePerFlower = 5;
}
else if (flower == "Dahlias")
{
    pricePerFlower = 3.80;
}
else if (flower == "Tulips")
{
    pricePerFlower = 2.80;
}
else if (flower == "Narcissus")
{
    pricePerFlower = 3;
}
else if (flower == "Gladiolus")
{
    pricePerFlower = 2.50;
}

double totalPrice = pricePerFlower * flowersNumber;

if (flower == "Roses" && flowersNumber > 80)
{
    totalPrice = totalPrice * 0.9;
}
else if ((flower == "Dahlias" && flowersNumber > 90) || (flower == "Tulips" && flowersNumber > 80))
{
    totalPrice = totalPrice * 0.85;
}
else if (flower == "Narcissus" && flowersNumber < 120)
{
    totalPrice = totalPrice * 1.15;
}
else if (flower == "Gladiolus" && flowersNumber < 80)
{
    totalPrice = totalPrice * 1.2;
}

if (totalPrice <= budget)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flower} and {budget - totalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
}
