int rentPrice = int.Parse(Console.ReadLine());

double statues = rentPrice * 0.7;
double catering = statues * 0.85;
double sound = catering * 0.5;

Console.WriteLine($"{statues + catering + sound + rentPrice:f2}");