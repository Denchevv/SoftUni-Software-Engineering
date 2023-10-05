int degrees = int.Parse(Console.ReadLine());
string timeOfTheDay = Console.ReadLine();


string outfit = "";
string shoes = "";

if (degrees >= 10 && degrees <=18)
{
	switch (timeOfTheDay)
	{
		case "Morning":
			outfit = "Sweatshirt";
			shoes = "Sneakers";
            break;
		case "Afternoon":
			outfit = "Shirt";
			shoes = "Moccasins";
			break;
		case "Evening":
			outfit = "Shirt";
			shoes = "Moccasins";
            break;
    }

}
else if (degrees > 18 && degrees <= 24)
{
    switch (timeOfTheDay)
    {
        case "Morning":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }

}
else
{
    switch (timeOfTheDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
    }

}
Console.WriteLine($"It's {d} degrees, get your {outfit} and {shoes}.");

