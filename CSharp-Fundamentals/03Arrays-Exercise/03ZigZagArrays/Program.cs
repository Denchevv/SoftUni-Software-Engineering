int n  = int.Parse(Console.ReadLine());

string[] firstArr = new string[n];
string[] secondArr = new string[n];

bool isFirstSelected = true;

for (int i = 0; i < n; i++)
{
    string[] numbersArray = Console.ReadLine().Split();



    if (isFirstSelected)
    {
        firstArr[i] = numbersArray[0];
        secondArr[i] = numbersArray[1];
    }
    else
    {
        firstArr[i] = numbersArray[1];
        secondArr[i] = numbersArray[0];
    }
    isFirstSelected = !isFirstSelected;
}

Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));