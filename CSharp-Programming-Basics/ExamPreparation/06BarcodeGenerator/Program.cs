int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int a1 = start / 1000; // It gives us the first digit =>EG: 2345 / 1000 = 2 
int a2 = start / 100 % 10; // => EG 2345 / 100 = 23 =>         23 % 10  = 3  
int a3 = start / 10 % 10;   //  EG 2345 / 10   = 234           234 % 10 = 4
int a4 = start % 10;         // EG                            2345 % 10 = 5

int b1 = end / 1000;
int b2 = end / 100 % 10;
int b3 = end / 10 % 10;
int b4 = end % 10;



for (int i = a1; i <= b1; i++)
{
    for (int i2 = a2; i2 <= b2; i2++)
    {
        for (int i3 = a3; i3 <= b3; i3++)
        {
           for(int i4 = a4; i4 <= b4; i4++)
            {
                if (i % 2 != 0 && i2 % 2 != 0 && i3 % 2 != 0 && i4 % 2 != 0)
                {
                    Console.Write($"{i}{i2}{i3}{i4} ");
                }

            }
        }
    }
        
    }