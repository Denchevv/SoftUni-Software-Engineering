//1. Read input
string studentName = Console.ReadLine();

//2. While loop and calculations
int classes = 1;
double gradesSum = 0;
int terminations = 0;

while (classes <= 12)
{
    double grades = double.Parse(Console.ReadLine());
    if (grades < 4)
    {
        terminations++;
        
        if (terminations < 2)
        {
            continue;
        }
        else
        {
            break;
        }
    }
    classes++;
    gradesSum += grades;
}

//3. Print output
if (classes >= 12)
{
    Console.WriteLine($"{studentName} graduated. Average grade: {gradesSum / 12:F2}");
}
else
{
    Console.WriteLine($"{studentName} has been excluded at {classes} grade");
}
