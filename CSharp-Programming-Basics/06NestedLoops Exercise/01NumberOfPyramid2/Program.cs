int n = int.Parse(Console.ReadLine());

int counter = 1;
bool isEqual = false;

for (int row = 1; !isEqual; row++)
{
	for (int col = 1; col <= row; col++)
	{
        Console.Write($"{counter} ");
        if( counter == n )
        {
            isEqual = true; 
            break;
        }
        counter++;
    }
    if (isEqual) { break; }
    Console.WriteLine();

}