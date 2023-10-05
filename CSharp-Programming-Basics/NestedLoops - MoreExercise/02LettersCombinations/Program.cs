char start = char.Parse(Console.ReadLine());
char end = char.Parse(Console.ReadLine());
char missThat = char.Parse(Console.ReadLine());

int counter = 0;

for (int i = start; i <= end; i++)
{
    for (int i2 = start; i2 <= end; i2++)
    {
        for (int i3 = start; i3 <= end; i3++)
        {
            if (i != missThat && i2 != missThat && i3 != missThat)
            {
                counter++;
                Console.Write((char)i);
                Console.Write((char)i2);
                Console.Write((char)i3 + " ");
            }
        }
    }

}
Console.Write(counter);