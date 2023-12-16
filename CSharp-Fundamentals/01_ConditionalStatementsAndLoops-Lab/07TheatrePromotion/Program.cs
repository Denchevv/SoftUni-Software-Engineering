/*Day / Age	0 <= age <= 18	18 < age <= 64	64 < age <= 122
Weekday	            12$	        18$	            12$
Weekend	            15$	        20$	            15$
Holiday	            5$	        12$	            10$
*/

string typeOfTheDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;
bool isError = false;

if (typeOfTheDay == "Weekday")
{
    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) { price = 12; }
    else if (age > 18 && age <= 64) { price = 18; }
    else { isError = true; }
 }
else if (typeOfTheDay == "Weekend")
{
    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122)) { price = 15; }
    else if (age > 18 && age <= 64) { price = 20; }
    else { isError = true; }
}
else if (typeOfTheDay == "Holiday")
{
    if (age >= 0 && age <= 18) price = 5;
    else if (age > 18 && age <= 64) { price = 12; }
    else if (age > 64 && age <= 122) { price = 10; }
    else { isError = true; }
}

if (isError)
{
    Console.WriteLine("Error!");
}
else
{
    Console.WriteLine($"{price}$");
}