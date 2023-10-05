//1. Read Input
//Снимка с трофея – символ – 'Y' (да) или 'N' (не)*/
string stage = Console.ReadLine();
string ticketType = Console.ReadLine();
int ticketsNumber = int.Parse(Console.ReadLine());
char photo = char.Parse(Console.ReadLine());

double price = 0;
//2. Conditional statements and calculations of the price

if (ticketType == "Standard")
{
    switch (stage)
    {
        case "Quarter final": price = 55.50;
            break;
        case "Semi final": price = 75.88; 
            break;
        case "Final": price = 110.10;
            break;
    }
}
else if (ticketType == "Premium")
{
    switch (stage)
    {
        case "Quarter final":
            price = 105.20;
            break;
        case "Semi final":
            price = 125.22;
            break;
        case "Final":
            price = 160.66;
            break;

    }

} 
else if (ticketType == "VIP")
{
    switch (stage)
    {
        case "Quarter final":
            price = 118.90;
            break;
        case "Semi final":
            price = 300.40;
            break;
        case "Final":
            price = 400;
            break;

    }
}
double totalPrice = price * ticketsNumber;
double discountedPrice = 0;
//3. Additional disctounts calculations
if (totalPrice > 4000)
{
    discountedPrice = totalPrice * 0.75;
}
else if (totalPrice > 2500)
{
    discountedPrice = totalPrice * 0.9;
}else
{
    discountedPrice = totalPrice;
}

if (photo == 'Y' && totalPrice <= 4000)
{
    discountedPrice += ticketsNumber * 40;
}

//4. Print output
Console.WriteLine($"{discountedPrice:f2}");
