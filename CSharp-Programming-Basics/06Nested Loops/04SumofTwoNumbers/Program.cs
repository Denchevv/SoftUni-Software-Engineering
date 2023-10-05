int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int magicN = int.Parse(Console.ReadLine());

int combinationNum = 0;
bool isFound = false;

for (int i = n1; i <= n2; i++)
{
    for (int j = n1; j <= n2; j++)
    {
        combinationNum++;
        if (i + j == magicN) 
        {
            Console.WriteLine($"Combination N:{combinationNum} ({i} + {j} = {magicN})");
            isFound = true;
            break;
        }
    }
    if (isFound) 
    {
        break; 
    }
}

if (!isFound)
{
    Console.WriteLine($"{combinationNum} combinations - neither equals {magicN}");
}