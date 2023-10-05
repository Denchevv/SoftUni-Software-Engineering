string product = Console.ReadLine();
string city =  Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

if (product == "coffee")
{
    switch (city)
    {
        case "Sofia":
            price = 0.5;
        break;
        case "Plovdiv":
            price = 0.4;
            break;
        default:
            price = 0.45;
            break;
    }
}
   
else if (product == "water")
{
    switch (city)
    {
        case "Sofia":
            price = 0.8;
        break;

        case "Plovdiv":
            price = 0.7;
            break;

        default:
            price = 0.7;
            break;
    }

}
else if (product == "beer")
{
    switch (city)
    {
        case "Sofia":
            price = 1.2;
        break;
        case "Plovdiv":
            price = 1.15;
            break;
        default:
            price = 1.10;
            break;
    }
}
else if (product == "sweets")
{
    switch (city)
    {
        case "Sofia":
            price = 1.45;
        break;
        case "Plovdiv":
            price = 1.30;
            break;
        default:
            price = 1.35;
            break;
    }
}
else if (product == "peanuts")
{
    switch (city)
    {
        case "Sofia":
            price = 1.60;
        break;
        case "Plovdiv":
            price = 1.50;
            break;
        default:
            price = 1.55;
            break;
    }
}

Console.WriteLine(price * quantity);