string username = Console.ReadLine();

string pass = "";
int failedCounter = 0;
bool isBlocked = false;

for (int i = username.Length - 1; i >= 0; i--)
{
    pass += username[i];
}

string currentPass = Console.ReadLine();
while (currentPass != pass)
{
    failedCounter++;
    
    if (failedCounter == 4)
    {
        isBlocked = true;
        break;
    }

    Console.WriteLine("Incorrect password. Try again.");

    currentPass = Console.ReadLine();
}

if (isBlocked)
{
    Console.WriteLine($"User {username} blocked!");
}
else
{
    Console.WriteLine($"User {username} logged in.");
}