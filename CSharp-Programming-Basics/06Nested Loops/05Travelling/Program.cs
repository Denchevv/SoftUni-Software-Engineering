// 1. Read input
string destination = Console.ReadLine();


while (destination != "End")
{
    double moneyNeeded = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    while (savedMoney < moneyNeeded)
    {
        double income = double.Parse((Console.ReadLine()));
        savedMoney += income;
    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}