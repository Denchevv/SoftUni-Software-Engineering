int totalSteps = 0;
bool quitEarlier = false;
const int goal = 10000;


while (totalSteps < goal)
{
    int newSteps = 0;
    string input = Console.ReadLine();
    if (input == "Going home")
    {
        newSteps = int.Parse(Console.ReadLine());
        totalSteps += newSteps;
        quitEarlier = true;
        break;
    }
    newSteps = int.Parse(input);
    totalSteps += newSteps;

}

if (quitEarlier && totalSteps < goal)
{
    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
}
else
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - goal  } steps over the goal!");
}