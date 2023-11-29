namespace _03_Problem
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            int valleyStart = 0;
            int peak = 0;
            int highestClimb = int.MinValue;
            int currentClimb = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentNumber = input[i];
                int nextNumber = input[i + 1];
                if (currentNumber > nextNumber)
                {
                    currentClimb = peak - valleyStart;
                    if( currentClimb > highestClimb )
                    {
                        highestClimb = currentClimb;
                    }
                    
                    valleyStart = currentNumber;

                }
                else
                {
                    peak = nextNumber;


                }
            }

            Console.WriteLine(highestClimb);

        }
    }
}