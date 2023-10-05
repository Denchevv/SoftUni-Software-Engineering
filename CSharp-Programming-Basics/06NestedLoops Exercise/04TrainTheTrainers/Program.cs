//1. Read input
int juryNumber = int.Parse(Console.ReadLine());


//2. Make the conditions for the loops
//  - calculate the average grade for current presentation - sum grades / jury number
// - calculate the average grade of all grades -> averagePerPresentation / counter presentations
int counter = 0;
double totalGrades = 0;

string presentationTopic = Console.ReadLine();

while (presentationTopic != "Finish")
{
    double sumGrades = 0;
   
    for (int i = 1; i <= juryNumber; i++)
    {
        double grades = double.Parse(Console.ReadLine());
        sumGrades += grades;
    }
    Console.WriteLine($"{presentationTopic} - {sumGrades / juryNumber:f2}.");

    totalGrades += sumGrades;
    counter++;
    presentationTopic = Console.ReadLine();
}
//3. Print output
double finalAssesment = totalGrades / (counter * juryNumber);
Console.WriteLine($"Student's final assessment is {finalAssesment:f2}.");



