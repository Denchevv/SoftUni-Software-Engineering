int hour = int.Parse(Console.ReadLine());   
string day =  Console.ReadLine();   

if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
{
    if (hour >= 10 && hour < 19)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }

}

else
{
    Console.WriteLine("closed");
}