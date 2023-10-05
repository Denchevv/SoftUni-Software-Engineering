//1. Input
int openTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//2. Calculation of the fine
for (int i = 1; i <= openTabs && salary > 0; i++)
{
    string websites = Console.ReadLine();

    if (websites == "Facebook") { salary -= 150; }
    else if (websites == "Instagram") { salary -= 100; }
    else if (websites == "Reddit") { salary -= 50; }

}
//3. Output
if (salary > 0)
{
    Console.WriteLine(salary);
}
else
{
    Console.WriteLine("You have lost your salary.");
}