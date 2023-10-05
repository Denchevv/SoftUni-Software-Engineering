//1. Read input
int tournamentsNum = int.Parse(Console.ReadLine()); 
int startingPoints = int.Parse(Console.ReadLine());

//2. Calculations

int pointsSum = 0;
int winsCounter = 0;
for (int i = 0; i < tournamentsNum; i++)
{
    string stageReached = Console.ReadLine();

    if (stageReached == "W") { pointsSum += 2000; winsCounter++; }
    else if (stageReached == "F") { pointsSum += 1200; }
    else if (stageReached == "SF") { pointsSum += 720; }

}

//3. Print output
Console.WriteLine($"Final points: {pointsSum + startingPoints}");
Console.WriteLine($"Average points: {pointsSum / tournamentsNum}");
Console.WriteLine($"{100.0 * winsCounter / tournamentsNum:f2}%");


