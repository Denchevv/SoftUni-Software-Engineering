// 1. Read input
double budget = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightSabersPrice = double.Parse(Console.ReadLine());
double robesPrice = double.Parse(Console.ReadLine());
double beltsPrice = double.Parse(Console.ReadLine());

// 2. Calculate the money for the equipment
lightSabersPrice = lightSabersPrice * Math.Ceiling(studentsCount * 1.10);
robesPrice = robesPrice * studentsCount;
beltsPrice = beltsPrice * (studentsCount - (studentsCount / 6));

double totalPrice = lightSabersPrice + robesPrice + beltsPrice;

// 3. Print output
if (totalPrice <= budget)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}else
{
    Console.WriteLine($"John will need {totalPrice - budget:f2}lv more.");
}



