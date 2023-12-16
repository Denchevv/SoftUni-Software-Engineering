// Read input
double budgetGiven = double.Parse(Console.ReadLine());
string gameName = Console.ReadLine();



// Calculate the money spend for the games

double moneySpend = 0;
double budgetLeft = budgetGiven;


while (gameName != "Game Time")
{
    bool boughtTheGame = false;
    bool tooExpensive = false;

    if (gameName == "CS: OG")
    {
        if (budgetLeft >= 15.99) { budgetLeft -= 15.99; boughtTheGame = true; moneySpend += 15.99; }
        else { tooExpensive = true; ; }

    }
    else if (gameName == "Zplinter Zell")
    {
        if (budgetLeft >= 19.99) { budgetLeft -= 19.99; boughtTheGame = true; moneySpend += 19.99; }
        else { tooExpensive = true; }

    }
    else if (gameName == "Honored 2")
    {
        if (budgetLeft >= 59.99) { budgetLeft -= 59.99; boughtTheGame = true; moneySpend += 59.99; }
        else { tooExpensive = true; }

    }
    else if (gameName == "RoverWatch")
    {
        if (budgetLeft >= 29.99) { budgetLeft -= 29.99; boughtTheGame = true; moneySpend += 29.99; }
        else { Console.WriteLine("Too Expensive"); }

    }
    else if (gameName == "RoverWatch Origins Edition" || gameName == "OutFall 4")
    {
        if (budgetLeft >= 39.99) { budgetLeft -= 39.99; boughtTheGame = true; moneySpend += 39.99; }
        else { tooExpensive = true; }

    }
    else { Console.WriteLine("Not Found"); }


    if (tooExpensive)
    {
        Console.WriteLine("Too Expensive");
    }
    if (boughtTheGame)
    {
        Console.WriteLine($"Bought {gameName}");
    }

    if (budgetLeft <= 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }

    gameName = Console.ReadLine();
}

// Print output

if (budgetLeft > 0)
{
    Console.WriteLine($"Total spent: ${(decimal)moneySpend:f2}. Remaining: ${(decimal)(budgetGiven - moneySpend):f2}");
}