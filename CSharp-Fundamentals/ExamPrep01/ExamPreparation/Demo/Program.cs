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

            int valleyStart = input[0];
            int valleyEnd = 0;
            int peak = 0;
            int currentElevation = 0;
            int maxElevation = int.MinValue;

            for (int i = 1; i < input.Length-1; i++)
            {
                int currentNum = input[i];
                int nextNum = input[i + 1];
                if (currentNum < nextNum)
                {
                    continue;
                }
                else if (currentNum > nextNum)
                {
                    peak = currentNum;

                    for (int j = i + 1; j < input.Length; j++)
                    {
                        int currentNum2 = input[j];
                        if (j < input.Length-1)
                        {
                            int nextNum2 = input[j + 1];
                            if (currentNum2 < nextNum2)
                            {
                                valleyEnd = currentNum2;
                                currentElevation = Math.Max(peak - valleyStart, peak - valleyEnd);

                                if (currentElevation > maxElevation)
                                {
                                    maxElevation = currentElevation;
                                }

                                valleyStart = valleyEnd;
                                i = j;
                                break;
                            }
                        }
                        else
                        {
                            valleyEnd = currentNum2;
                            currentElevation = Math.Max(peak - valleyStart, peak - valleyEnd);

                            if (currentElevation > maxElevation)
                            {
                                maxElevation = currentElevation;
                            }
                            i = j;
                        }                     
                    }
                   
                }

            }
            Console.WriteLine(maxElevation);
        }
    }
}