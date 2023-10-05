int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakeSize = width * length;

string input = Console.ReadLine();
while (input != "STOP")
{
    int newPieces = int.Parse(input);
    cakeSize -= newPieces;

    if (cakeSize <= 0) { break; }

    input = Console.ReadLine();
}

if (0 > cakeSize)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
}
else
{
    Console.WriteLine($"{cakeSize} pieces are left.");
}