using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                3, 3, 6, 1

            };

            var resultList = new List<int>();

            for(int i = 0; i < list.Count-1; i++)
            {
                int currentNum = list[i];
                int nextNum = list[i + 1];

                if(currentNum == nextNum)
                {
                    list[i] = 2*currentNum;
                    list.RemoveAt(i+1);
                    i = -1 ;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}