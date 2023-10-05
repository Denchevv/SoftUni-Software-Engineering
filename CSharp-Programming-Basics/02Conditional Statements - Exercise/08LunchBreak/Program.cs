string movieName = Console.ReadLine();
int movieLength = int.Parse(Console.ReadLine());    
int breakLength = int.Parse(Console.ReadLine());


double timeNeeded = breakLength * 0.125 + breakLength * 0.25;
double timeLeft = breakLength - timeNeeded;

if (timeLeft >= movieLength)
{
    Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeLeft - movieLength)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(movieLength - timeLeft)} more minutes.");
}
