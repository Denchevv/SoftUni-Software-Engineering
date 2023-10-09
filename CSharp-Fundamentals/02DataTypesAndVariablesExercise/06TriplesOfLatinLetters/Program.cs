int range = int.Parse(Console.ReadLine());


for (int a = 97; a < 97 + range; a++)
{
    for (int b = 97; b < 97 + range; b++)
    {
        for (int c = 97; c < 97 + range; c++)
        {
            Console.WriteLine($"{(char)a}{(char)b}{(char)c} ");

        }

    }

}