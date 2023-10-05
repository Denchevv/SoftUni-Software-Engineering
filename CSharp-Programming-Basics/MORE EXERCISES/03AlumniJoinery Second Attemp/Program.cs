int numberJoineries = int.Parse(Console.ReadLine());
string typeJoinery = Console.ReadLine();
string delivery = Console.ReadLine();

double price = 0;

if (numberJoineries < 10)
{
    Console.WriteLine("Invalid order");
}
else { 

if (typeJoinery == "90X130")
{
    price = 110;
    if (numberJoineries >= 30 && numberJoineries <= 60) { price *= 0.95; }
    else if (numberJoineries > 60) { price = price * 0.92; }
    
}
else if (typeJoinery == "100X150")
{
    price = 140;
    if (numberJoineries >= 40 && numberJoineries <= 80) { price = price * 0.94; }
    else if (numberJoineries > 80) { price = price * 0.9; }
    
}
else if (typeJoinery == "130X180")
{
    price = 190;
    if (numberJoineries >= 20 && numberJoineries <= 50) { price = price * 0.93; }
    else if (numberJoineries > 50) { price = price * 0.88; }
}
else if (typeJoinery == "200X300")
{
    price = 250;
    if (numberJoineries >= 25 && numberJoineries <= 50) { price = price * 0.91; }
    else if (numberJoineries > 50) { price = price * 0.86; }
    
}

double totalPrice = price * numberJoineries;

if (delivery == "With delivery") { totalPrice += 60; }
if (numberJoineries >= 100) {  totalPrice *= 0.96; }


 Console.WriteLine($"{totalPrice:f2} BGN");
}