//1.Read input
string actorName = Console.ReadLine();
double pointsAcademy = double.Parse(Console.ReadLine());
int juryNumb = int.Parse(Console.ReadLine());

//2.Calculation
for (int i = 1; i <= juryNumb && pointsAcademy <= 1250.5; i++)
{
    string juryName = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());

    pointsAcademy += juryName.Length * points / 2;
    
}
//3. Print output
if (pointsAcademy > 1250.5)
{
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsAcademy:f1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsAcademy:f1} more!");
}
