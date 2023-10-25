namespace _11Kamino
{
    internal class Program
    {
        static void Main()
        {

            int dnaLength = int.Parse(Console.ReadLine());

            int[] finalDNA = new int[dnaLength];

            int maxLength = 0;
            int maxIndex = -1;
            int currentRow = 1;
            int bestRow = 0;
            int bestSum = 0;


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = line
                                  .Split('!', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

                int currentSum = 0;
                int check = currentDNA.Length;

                for (int i = 0; i < currentDNA.Length; i++)
                {

                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                int currentLength = 0;
                int currentIndex = -1;

                if (currentRow == 1)
                {
                    finalDNA = currentDNA;
                    bestRow = currentRow;
                    bestSum = currentSum;
                }

                for (int i = 0; i < currentDNA.Length; i++)
                {


                    if (currentDNA[i] == 1)
                    {
                        currentIndex = i;
                        currentLength++;
                        //FirstCondition
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            maxIndex = i;
                            bestRow = currentRow;
                            bestSum = currentSum;

                            finalDNA = currentDNA;
                        }
                        else if (currentLength == maxLength)
                        {
                            if (currentIndex < maxIndex)
                            {
                                maxLength = currentLength;
                                maxIndex = i;
                                bestRow = currentRow;
                                bestSum = currentSum;

                                finalDNA = currentDNA;
                            }
                            else if (currentSum > bestSum)
                            {
                                maxLength = currentLength;
                                maxIndex = i;
                                bestRow = currentRow;
                                bestSum = currentSum;

                                finalDNA = currentDNA;
                            }
                        }

                    }
                    else
                    {
                        currentLength = 0;
                        currentIndex = -1;
                    }
                }
                currentRow++;
            }
            Console.WriteLine($"Best DNA sample {bestRow} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", finalDNA));
        }
    }

}



