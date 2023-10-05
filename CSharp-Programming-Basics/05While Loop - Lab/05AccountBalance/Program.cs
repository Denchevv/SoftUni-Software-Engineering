string input = Console.ReadLine();

double sum = 0;

while (input != "NoMoreMoney")
{
    double amount = double.Parse(input);
    
    if (amount < 0 ) 
    {
        Console.WriteLine("Invalid operation!");
        break; 
    }
    Console.WriteLine($"Increase: {amount:f2}");
    sum += amount;
    input = Console.ReadLine();
}

Console.WriteLine($"Total: {sum:f2}");