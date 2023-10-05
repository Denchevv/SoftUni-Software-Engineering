int hours = int.Parse(Console.ReadLine());
int munites = int.Parse(Console.ReadLine());

int totalMins = hours * 60 + munites + 15;

int newHour = totalMins / 60;
int newMins = totalMins % 60;

if (newHour > 23)
{
    newHour = 0;
}

if (newMins < 10)
{
    Console.WriteLine($"{newHour}:0{newMins}");
}
else
{
     Console.WriteLine($"{newHour}:{newMins}");
}