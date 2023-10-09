int ordersNum = int.Parse(Console.ReadLine());

double total = 0;

for (int i = 0; i < ordersNum; i++)
{
    double currentPrice = 0;

    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());

    currentPrice = (days * capsuleCount) * capsulePrice;
    total += currentPrice;

    Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
}
Console.WriteLine($"Total: ${total:f2}");