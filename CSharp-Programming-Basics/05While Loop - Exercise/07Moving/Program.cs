//1.Read input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height= int.Parse(Console.ReadLine());

int roomVolume = width * length * height;
int boxesCount = 0;

//2. While loop and conditional statements.
string input = Console.ReadLine();
while (input != "Done")
{
    int boxes = int.Parse(input);
    boxesCount += boxes;
    if (boxesCount >= roomVolume) {  break; }

    input = Console.ReadLine();
}

//3. Print ouput.
if (roomVolume > boxesCount)
{
    Console.WriteLine($"{roomVolume - boxesCount} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {boxesCount - roomVolume} Cubic meters more.");
}