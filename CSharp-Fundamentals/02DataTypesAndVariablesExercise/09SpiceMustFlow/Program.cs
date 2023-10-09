// Input 
int yield = int.Parse(Console.ReadLine());

int daysCount = 0;
int totalYield = 0;

while (yield >= 100)
{
    daysCount++;
    totalYield += yield;
    totalYield -= 26;

    yield -= 10;
}
// - 26 additional after exhausting of the mine
if(totalYield >= 26)
{
    totalYield -= 26;
}

Console.WriteLine(daysCount);
Console.WriteLine(totalYield);