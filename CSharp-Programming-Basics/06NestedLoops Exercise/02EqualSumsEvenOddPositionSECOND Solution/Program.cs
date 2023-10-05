int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    int oddSum = 0, evenSum = 0;

    string currentNum = i.ToString();

    for (int j = 0; j < currentNum.Length; j++)
    {
        int currentDigit = int.Parse(currentNum[j].ToString());

        if (j % 2 == 0) { evenSum += currentDigit; }
        else { oddSum += currentDigit; }
    }
    if (oddSum == evenSum)
    {
        Console.Write(i + " ");
    }

}