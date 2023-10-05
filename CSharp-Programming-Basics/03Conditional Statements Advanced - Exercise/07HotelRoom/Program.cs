string month = Console.ReadLine();
int duration = int.Parse(Console.ReadLine());

double apartamentCosts = 0;
double studioCosts = 0;

if (month == "May" ||  month == "October")
{
    studioCosts = duration * 50;
    apartamentCosts = duration * 65;

}
else if (month == "June" || month == "September")
{
    studioCosts = duration * 75.2;
    apartamentCosts = duration * 68.7;
}
else if (month == "July" || month == "August")
{
    studioCosts = duration * 76;
    apartamentCosts = duration * 77;
}


if ((duration > 14 && month == "May") || (duration > 14 && month == "October"))
{
    studioCosts = studioCosts * 0.7; 
}
else if ((duration > 7 && month == "May") || (duration > 7 && month == "October"))
{ 
        studioCosts = studioCosts * 0.95; 
}
else if ((duration > 14 && month == "June") || (duration > 14 && month == "September"))
{
    studioCosts = studioCosts * 0.8;
}

if (duration > 14)
{
    apartamentCosts = apartamentCosts * 0.9;
}

Console.WriteLine($"Apartment: {apartamentCosts:f2} lv.");
Console.WriteLine($"Studio: {studioCosts:f2} lv.");
