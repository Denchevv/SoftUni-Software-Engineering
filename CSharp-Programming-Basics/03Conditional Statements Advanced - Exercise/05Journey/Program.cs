double budget = double.Parse(Console.ReadLine());
string season =  Console.ReadLine();


double spendings = 0;
string place = "";
string accomodation = "";

if (budget <= 100)
{
    place = "Bulgaria";
    if (season == "summer")
    {
        spendings = budget * 0.3;
        accomodation = "Camp";
    }
    else
    {
        spendings = budget * 0.7;
        accomodation = "Hotel";
    }

}
else if (budget <= 1000)
{
    place = "Balkans";
    if (season == "summer")
    {
        spendings = budget * 0.4;
        accomodation = "Camp";
    }
    else
    {
        spendings = budget * 0.8;
        accomodation = "Hotel";
    }

}
else
{
    place = "Europe";
    accomodation = "Hotel";
    spendings = budget * 0.9;
}


Console.WriteLine($"Somewhere in {place}");
Console.WriteLine($"{accomodation} - {spendings:f2}");