namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int[] firstNums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int count = firstNums[0];
            int numsToPop = firstNums[1];
            int wantedNum = firstNums[2];
            
            int[] numbersArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            

            var numbersStack = new Stack<int>(numbersArray);

            for (int i = 0; i < numsToPop; i++)
            {
                int poppedNum = numbersStack.Pop();
            }

            if(numbersStack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool contains = numbersStack.Contains(wantedNum);
                if(contains)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbersStack.Min());
                }
            }

        }
    }
}
