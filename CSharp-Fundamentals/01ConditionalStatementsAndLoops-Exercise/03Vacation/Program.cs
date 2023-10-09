int groupCount = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double currentPrice = 0;
double totalPrice = 0;

if (typeOfGroup == "Students")
{
    if (dayOfWeek == "Friday") { currentPrice = 8.45; }
    else if (dayOfWeek == "Saturday") { currentPrice = 9.80; }
    else if (dayOfWeek == "Sunday") { currentPrice = 10.46; }
}
else if (typeOfGroup == "Business")
{
    if (dayOfWeek == "Friday") { currentPrice = 10.90; }
    else if (dayOfWeek == "Saturday") { currentPrice = 15.60; }
    else if (dayOfWeek == "Sunday") { currentPrice = 16; }
}
else if (typeOfGroup == "Regular")
{
    if (dayOfWeek == "Friday") { currentPrice = 15; }
    else if (dayOfWeek == "Saturday") { currentPrice = 20; }
    else if (dayOfWeek == "Sunday") { currentPrice = 22.50; }

}

totalPrice = currentPrice * groupCount;

if (typeOfGroup == "Students" && groupCount >= 30) { totalPrice *= 0.85; }
if (typeOfGroup == "Business" && groupCount >= 100) { totalPrice -= (10 * currentPrice); }
if (typeOfGroup == "Regular" && groupCount >= 10 && groupCount <= 20) { totalPrice *= 0.95; }

Console.WriteLine($"Total price: {totalPrice:f2}");
