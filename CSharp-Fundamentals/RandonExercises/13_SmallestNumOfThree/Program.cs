﻿namespace _13_SmallestNumOfThree
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());



            int smallerNum = SmallerNumber(a, b);
            int result = SmallerNumber(smallerNum, c);
                        
            Console.WriteLine(result);
        }

        private static int SmallerNumber(int firstNum, int secondNum)
        {
            return firstNum < secondNum ? firstNum : secondNum;
        }
    }
}