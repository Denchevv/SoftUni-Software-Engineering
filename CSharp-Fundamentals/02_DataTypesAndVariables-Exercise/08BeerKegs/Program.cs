int n = int.Parse(Console.ReadLine());

double biggestKeg = 0;
string winner = "";

for (int i = 1; i <= n; i++)
{

    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    //π * r^2 * h. 
    double volume = Math.PI * Math.Pow(radius, 2) * height;

    if (volume > biggestKeg)
    {
        biggestKeg = volume;
        winner = model;
    }
    
}
Console.WriteLine(winner);