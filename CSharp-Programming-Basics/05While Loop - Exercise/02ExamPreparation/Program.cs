int lowGradeLimit = int.Parse(Console.ReadLine());

int gradesSum = 0;
int problemsCount = 0;
int lowGradesCount = 0;
string lastProblem = "";
bool flag = false;

string input = Console.ReadLine();
while (input != "Enough")
{
    int inputGrade = int.Parse(Console.ReadLine());
    gradesSum += inputGrade;

    if (inputGrade <= 4)
    {
        lowGradesCount++;
        if (lowGradesCount == lowGradeLimit)
        {
            flag = true;
            break;
        }
    }

    lastProblem = input;
    problemsCount++;
    input = Console.ReadLine();
}

if (!flag)
{
    Console.WriteLine($"Average score: {1.0 * gradesSum / problemsCount:F2}");
    Console.WriteLine($"Number of problems: {problemsCount}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
else
{
    Console.WriteLine($"You need a break, {lowGradesCount} poor grades.");
}