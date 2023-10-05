int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    for (int i2 = start; i2 <= end; i2++)
    {
        for (int i3 = start; i3 <= end; i3++)
        {
            for(int i4 = start; i4 <= end; i4++)
            {
               /* if ((i % 2 == 0 && i4 % 2 != 0) && i > i4 && (i2 + i3) % 2 == 0
                    || (i % 2 != 0 && i4 % 2 == 0 && i > i4 && (i2 + i3) % 2 == 0))
               }*/

                if (i > i4 && (i2 + i3) % 2 == 0)
                {
                    if(i % 2 == 0 && i4 % 2 != 0)
                    {
                        Console.Write($"{i}{i2}{i3}{i4} ");
                    }
                    else if (i % 2 != 0 && i4 % 2 == 0)
                    {
                        Console.Write($"{i}{i2}{i3}{i4} ");
                    }             
                }
            }
        }
    }
}