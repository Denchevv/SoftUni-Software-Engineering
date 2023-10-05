double recordTime = double.Parse(Console.ReadLine());
double distanceToCover = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

//2.Calculations
double timeNeeded = distanceToCover * timePerMeter;
double delay = Math.Floor(distanceToCover / 50) * 30;

timeNeeded += delay;

if (timeNeeded >= recordTime)
{
    Console.WriteLine($"No! He was {timeNeeded - recordTime:f2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes! The new record is {timeNeeded:f2} seconds.");
}


