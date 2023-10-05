int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivialHour = int.Parse(Console.ReadLine());
int arrivalMinunte = int.Parse(Console.ReadLine());

int examSumMin = examHour * 60 + examMinute;
int arrivalSumMin = arrivialHour * 60 + arrivalMinunte;
int result1 = examSumMin - arrivalSumMin;

string verdict = "";
string keyword = "";

if (result1 < 0)
{
    verdict = "Late";
    keyword = "after";
}
else
{
    keyword = "before";

    if (result1 <= 30) { verdict = "On time"; }
    else { verdict = "Early"; }
}

int absolutTime = Math.Abs(result1);
string formattedTime = "";


if (absolutTime >= 60)
{
    int hours = absolutTime / 60;
    int mins = absolutTime % 60;

    if (mins < 10) { formattedTime = $"{hours}:0{mins} hours"; }
    else { formattedTime = $"{hours}:{mins} hours"; }

}
else {
    formattedTime = $"{absolutTime} minutes";
}

Console.WriteLine($"{verdict}");

if (result1 != 0)
{
    
    Console.WriteLine($"{formattedTime} {keyword} the start");
}