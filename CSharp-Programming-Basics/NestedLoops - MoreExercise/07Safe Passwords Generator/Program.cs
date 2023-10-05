int aRange = int.Parse(Console.ReadLine());
int bRange = int.Parse(Console.ReadLine());  
int passLimit = int.Parse(Console.ReadLine());

int counter = 0;

int asciStartA = 35;
int asciStartB = 64;
bool isReached = false;
//											ABxyBA
//Loop for A
for (int a = asciStartA; a <= 56; a++)
{
	//Loop for B
	for (int b = asciStartB; b < 97; b++)
	{
		//Loop for x
		for (int x = 1; x <= aRange; x++) 
		{
			//Loop for y
			for(int y = 1; y <= bRange; y++)
			{
                
				Console.Write($"{(char)a}{(char)b}{x}{y}{(char)b}{(char)a}|");
                b += 1;
                if (b > 96) { b = 64; }

                a += 1;
                if (a > 55) { a = 35; }

                counter++;

				if (counter == passLimit || x == aRange && y == bRange)
				{
					isReached = true;
					break;
				}
				if (isReached) { break; }
            }
            if (isReached) { break; }
        }
        if (isReached) { break; }
	}
    if (isReached) { break; }

    
}
