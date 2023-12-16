using System.Diagnostics;

static void PrintGrade(double grades)
{
    if (grades >= 2 && grades < 3)
    {
        Console.WriteLine("Fail");
    }
    else if (grades < 3.50)
    {
        Console.WriteLine("Poor");
    }
    else if (grades < 4.50) 
    {
        Console.WriteLine("Good");
    }
    else if (grades < 5.5)
    {
        Console.WriteLine("Very good");
    }
    else if (grades <= 6)
    {
        Console.WriteLine("Excellent");
    }
}

PrintGrade(double.Parse(Console.ReadLine()));
