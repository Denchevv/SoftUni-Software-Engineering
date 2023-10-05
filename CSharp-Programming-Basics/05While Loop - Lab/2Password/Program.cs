string username = Console.ReadLine();
string pass = Console.ReadLine();



string input = Console.ReadLine();
while (pass != input)
{
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");