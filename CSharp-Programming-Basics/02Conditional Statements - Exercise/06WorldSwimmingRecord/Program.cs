
double recordTime = double.Parse(Console.ReadLine());
double metersToSwim = double.Parse(Console.ReadLine()); 
double ivanPerMeter = double.Parse(Console.ReadLine());

double ivanResult = metersToSwim * ivanPerMeter + Math.Floor(metersToSwim / 15) * 12.5;


/*if (metersToSwim >= 15)
{
   int delay = ((int)metersToSwim / 15);

  double delayedSeconds = delay * 12.5;
   ivanResult = ivanResult + delayedSeconds;
}*/

if (ivanResult < recordTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {ivanResult:f2} seconds.");
} else if (ivanResult >= recordTime)
{
    Console.WriteLine($"No, he failed! He was {ivanResult - recordTime:f2} seconds slower.");
}
