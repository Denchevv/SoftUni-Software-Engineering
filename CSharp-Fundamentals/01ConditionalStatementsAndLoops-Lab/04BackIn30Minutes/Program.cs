int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int totalMins = hours * 60 + minutes + 30;

hours = totalMins / 60;
minutes = totalMins % 60;

if (hours > 23)
{
    hours = 0;
}

Console.WriteLine($"{hours}:{minutes:D2}");
//* OR Another SOlution:
//  if (minutes > 59)
//  { 
//      hours++;
//      minutes -= 60; 
//  }
//      if(hours > 23) {
//      hours = 0;
//      CW .... */