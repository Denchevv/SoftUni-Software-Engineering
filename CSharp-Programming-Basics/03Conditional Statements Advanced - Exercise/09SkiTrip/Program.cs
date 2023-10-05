int daysToStay = int.Parse(Console.ReadLine());
string typeOfAccom= Console.ReadLine();
string survey = Console.ReadLine();

double price = 0;

if (typeOfAccom == "room for one person")
{
    price = (daysToStay - 1) * 18;
}


else if (typeOfAccom == "apartment")
{
    price = (daysToStay - 1) * 25;

    if (daysToStay < 10) { price = price * 0.7; }
    else if (daysToStay > 9 && daysToStay < 16) { price = price * 0.65; }
    else if (daysToStay > 15) { price = price * 0.5; }
}
else if (typeOfAccom == "president apartment")
{
    price = (daysToStay - 1) * 35;

    if (daysToStay < 10) { price = price * 0.9; }
    else if (daysToStay > 9 && daysToStay < 16) { price = price * 0.85; }
    else if (daysToStay > 15) { price = price * 0.8; }
}

if (survey == "positive") { price = price * 1.25; }
else { price = price * 0.9; }

Console.WriteLine($"{price:f2}");