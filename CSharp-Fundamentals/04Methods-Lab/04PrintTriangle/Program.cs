int lines = int.Parse(Console.ReadLine());
PrintTriangle(lines);
static void PrintLine(int length)
{
 for (int i = 1;  i <= length; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int n)
{
    for(int i = 1;i <= n;i++)
    {
        PrintLine(i);
    }

    for (int i  = n - 1; i  >= 1; i --)
    {
        PrintLine(i);
    }
}



//static void PrintTriangle(int lines)
//{

//    // Print the top half of the pattern

//    for (int i = 1; i <= lines; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write(j + " ");
//        }
//        Console.WriteLine();
//    }

//    // Print the bottom half of the pattern
//    for (int i2 = lines - 1; i2 >= 1; i2--)
//    {
//        for (int j = 1; j <= i2; j++)
//        {
//            Console.Write(j + " ");
//        }
//        Console.WriteLine();
//    }
//}

//int lines = int.Parse(Console.ReadLine());
//PrintTriangle(lines);