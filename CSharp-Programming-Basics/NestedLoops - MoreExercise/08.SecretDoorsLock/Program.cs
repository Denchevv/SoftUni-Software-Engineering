int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

for (int i = 2; i <= n1; i += 2) 
{
	for (int i2 = 2; i2 <= n2; i2++)
	{
		for (int i3 = 2; i3 <= n3; i3+=2)
		{
			if (i2 == 2 || i2 == 3 || i2 == 5 || i2 == 7)
			{
                Console.WriteLine($"{i} {i2} {i3}");
            }
		}

	}

}