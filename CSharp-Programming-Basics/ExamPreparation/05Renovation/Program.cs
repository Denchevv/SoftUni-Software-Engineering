//1. Read input
int width = int.Parse(Console.ReadLine()); 
int length = int.Parse(Console.ReadLine()); 
int percentNoPaiting = int.Parse(Console.ReadLine());

//2. While loop + calculations
int roomVolume = width * length * 4;
double paintingVolume = roomVolume - (roomVolume * (1.0 * percentNoPaiting / 100));


bool isFinished = false;

string input = Console.ReadLine();
while (input != "Tired!")
{
    int litersPaint = int.Parse(input);
    paintingVolume -= litersPaint;

    if(paintingVolume <= 0)
    {
        isFinished = true;
        break;
    }

    input = Console.ReadLine();
}
//3.Print output
if (isFinished)
{
    if(paintingVolume == 0)
    {
        Console.WriteLine("All walls are painted! Great job, Pesho!");
    }else
    {
        Console.WriteLine($"All walls are painted and you have {Math.Abs(paintingVolume)} l paint left!");
    }
}
else
{
    Console.WriteLine($"{paintingVolume} quadratic m left.");
}