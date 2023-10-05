int mansNum = int.Parse(Console.ReadLine());
int womenNum = int.Parse(Console.ReadLine());
int availableTables =  int.Parse(Console.ReadLine());

int counter  = 0;
bool isFull = true;

for (int i = 1;  i <= mansNum; i++)
{
	for (int i2 = 1; i2 <= womenNum; i2++)
	{
        Console.Write($"({i} <-> {i2}) ");
			counter++;
		if (counter == availableTables)
		{
			isFull = false;
			break;
		}
	}
	if (!isFull) { break; }
}