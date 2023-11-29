namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int valleyStart = 0;
            int peak = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (i == 0)
                {
                    valleyStart = i;
                }
                else
                {
                    int nextNum = input[i + 1];
                    int currentNum = input[i];
                    
                    if (valleyStart < nextNum)
                    {
                        peak = nextNum;


                    }


                }

            }
        }
    }
}