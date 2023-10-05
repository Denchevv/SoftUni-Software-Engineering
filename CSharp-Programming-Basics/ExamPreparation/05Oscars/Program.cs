//1.Read Input
string actorsName = Console.ReadLine();
double pointsAcademy = double.Parse(Console.ReadLine()); 
int juryNumber = int.Parse(Console.ReadLine());

//2. For loop and calculaltions
bool isNominated = false;
double totalPoints = pointsAcademy;

for (int i = 1; i <= juryNumber; i++)
{
   
    string nameJury = Console.ReadLine();
    double pointsGiven = double.Parse(Console.ReadLine());

    double givenPoints = (nameJury.Length * pointsGiven) / 2;
    totalPoints += givenPoints;

    if (totalPoints >= 1250.5)
    {
        isNominated = true;
        break;
    }
}


if (isNominated)
{
    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {totalPoints:f1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorsName} you need {1250.5 - totalPoints:f1} more!");
}