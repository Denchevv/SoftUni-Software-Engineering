int examHour = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMin = int.Parse(Console.ReadLine());

int examTotalTime = examHour * 60 + examMin;
int arrivalTotalTime = arrivalHour * 60 + arrivalMin;

int diff = examTotalTime -  arrivalTotalTime;

string timing = "";
string keyword = "";

if (diff < 0)
{
    timing = "Late";
    keyword = "after";
}
else
{
    keyword = "before";

    if (diff > 30) { timing = "Early"; }
    else { timing = "On time"; }
}
int diffAbs = Math.Abs(diff);

string timeConstraints = "";

if (diffAbs >= 60)
{
    int hour = diffAbs / 60;
    int min = diffAbs % 60;

    if (min < 10)
    {
        timeConstraints = $"{hour}:0{min} hours";
    }
    else
    {
        timeConstraints = $"{hour}:{min} hours";
    }
} else
{
    timeConstraints = $"{diffAbs} minutes";
}

if (diff != 0)
{
    Console.WriteLine($"{timing}");
    Console.WriteLine($"{timeConstraints} {keyword} the start");
}
else
{
    Console.WriteLine($"{timing}");
}