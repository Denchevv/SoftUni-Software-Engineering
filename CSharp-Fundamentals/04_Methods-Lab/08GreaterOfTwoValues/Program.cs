string type = Console.ReadLine();

switch (type)
{
    case "int":
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int result = GetMax(firstNum, secondNum);
        break;
    case "char":
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char resultChar = (char)GetMax(firstChar, secondChar);
        break;
}

static int GetMax(int a, int b)
{
    int result = Math.Max(a, b);
    return result;
}
static char GetMax(char a, char b)
{
    int result = Math.Max(a, b);
    return (char)result;
}
static string GetMax(string a, string b)
{
    int result = a.CompareTo(b);

    if (result > 0)
    {
        return a;
    }
    else
    {
        return b;
    }
}