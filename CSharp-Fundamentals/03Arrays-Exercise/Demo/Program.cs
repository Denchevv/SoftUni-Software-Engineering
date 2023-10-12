int n = int.Parse(Console.ReadLine());

string[] firstArr = new string[n];
string[] secondArr = new string[n];

bool inFirstArr = true;

for (int i = 0; i < n; i++)
{
    string[] numbers = Console.ReadLine().Split();

    if (inFirstArr)
    {
        firstArr[i] = numbers[0];
        secondArr[i] = numbers[1];
    }
    else
    {
        firstArr[i] = numbers[1];
        secondArr[i] = numbers[0];
    }

    inFirstArr = !inFirstArr;
}
Console.WriteLine(string.Join(" ", firstArr));
Console.Write(string.Join(" ", secondArr));