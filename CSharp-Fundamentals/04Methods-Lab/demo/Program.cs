string input = Console.ReadLine();
int repeats = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatText(input, repeats));
static string RepeatText(string text, int repeats)
{
    string result = string.Empty;
    for (int i = 0; i < repeats; i++)
    {
        result += text;
    }

    return result;
}