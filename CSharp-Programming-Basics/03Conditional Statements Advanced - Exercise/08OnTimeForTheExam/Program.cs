int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivialHour = int.Parse(Console.ReadLine());
int arrivalMinunte = int.Parse(Console.ReadLine());

int examSumMin = examHour * 60 + examMinute;
int arrivalSumMin = arrivialHour * 60 + arrivalMinunte;
int result1 = examSumMin - arrivalSumMin;

if (examSumMin >= arrivalSumMin)
{

    if (result1 <= 30)
    {
        Console.WriteLine("On time");
    }
    else if (result1 > 30)
    {
        Console.WriteLine("Early");
    }
}
else
{
    Console.WriteLine("Late");
}


if (result1 < 0)
{
    result1 = Math.Abs(result1);
    if (result1 > 60)
    {
        int hour = result1 / 60;
        int minute = result1 % 60;

        if (minute < 10)
        {
            Console.WriteLine($"{hour}:0{minute} hours after the start");
        }
        else
        {
            Console.WriteLine($"{hour}:{minute} hours after the start");
        }
    }
    else
    {
        Console.WriteLine($"{Math.Abs(result1)} minutes after the start");
    }
}
else if (result1 > 0)
{
    if (result1 >= 60)
    {
        
        int hour = Math.Abs(result1) / 60;
        int minute = Math.Abs(result1) % 60;

        if (minute < 10)
        {
            Console.WriteLine($"{hour}:0{minute} hours before the start");
        }
        else
        {
            Console.WriteLine($"{hour}:{minute} hours before the start");
        }
    }
    else
    {
        Console.WriteLine($"{Math.Abs(result1)} minutes before the start");
    }
}