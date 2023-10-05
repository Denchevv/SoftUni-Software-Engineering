int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int combinationNum = 0;
bool isFound = false;

for (int i = start; i <= end; i++)
{
    for (int i2 = start; i2 <= end; i2++)
    {
        combinationNum++;
        if (i + i2 == magicNum)
        {
            Console.WriteLine($"Combination N:{combinationNum} ({i} + {i2} = {magicNum})");
            isFound = true;
            break;
        }
    }
    if (isFound) { break;}
}
Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");
