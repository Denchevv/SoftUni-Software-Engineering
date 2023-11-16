namespace Demo
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(j % 2 == 0)
                    {
                        break;
                    }
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }
    }
}