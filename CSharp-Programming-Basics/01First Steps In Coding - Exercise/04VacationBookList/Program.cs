int pagesCurrentBook = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());   
int deadlineDays = int.Parse(Console.ReadLine());

int hoursNeededPerBook = pagesCurrentBook / pagesPerHour;
int hoursNeededTotal = hoursNeededPerBook / deadlineDays;

Console.WriteLine(hoursNeededTotal);