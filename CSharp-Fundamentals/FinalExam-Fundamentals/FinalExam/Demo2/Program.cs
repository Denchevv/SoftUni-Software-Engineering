namespace Demo2
{
    public class Program
    {
        public static void Main()
        {
            int lengthSeq = int.Parse(Console.ReadLine());

            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            string[] resultDNA = new string[0];
            int bestLength = 0;
            int sequenceIndex = 0;
            int bestStartIndex = -1;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }
                int currentLength = 1;
                int length = 1;
                int currentStartIndex = -1;

                string[] originalDNA = line.Split("!");

                sequenceIndex++;

                //SUM of the DNA ones
                int currentSum = SumAllOnes(originalDNA);

                //Check if there is only 1 Sequence
               /* if(sequenceIndex == 1)
                {
                    bestSequenceIndex = sequenceIndex;
                    bestSequenceSum = currentSum;

                    resultDNA = originalDNA;
                }*/

                //Check for the length of each DNA sequence and finding the longest one
                for (int i = 0; i < originalDNA.Length - 1; i++)
                {
                    if (originalDNA[i] == "1")
                    {
                        if (originalDNA[i] == originalDNA[i + 1])
                        {
                            currentLength++;
                            
                            if (currentLength > length)
                            {
                                length = currentLength;
                                currentStartIndex = i;
                            }
                        }
                        else
                        {
                            currentLength = 1;
                            
                        }
                    }
                }
                // First condition IF This is the longest sequence
                if (length > bestLength)
                {
                    bestSequenceIndex = sequenceIndex;
                    bestLength = length;
                    bestSequenceSum = currentSum;
                    bestStartIndex = currentStartIndex;
                    bestSequenceSum = currentSum;

                    resultDNA = originalDNA;
                }
                else if (length == bestLength)
                {
                    if (currentStartIndex < bestStartIndex)
                    {
                        bestSequenceIndex = sequenceIndex;
                        bestLength = length;
                        bestSequenceSum = currentSum;
                        bestStartIndex = currentStartIndex;
                        bestSequenceSum = currentSum;


                        resultDNA = originalDNA;
                    }
                    else if (currentStartIndex == bestStartIndex)
                    {
                        if (currentSum > bestSequenceSum)
                        {
                            bestSequenceIndex = sequenceIndex;
                            bestLength = length;
                            bestSequenceSum = currentSum;
                            bestStartIndex = currentStartIndex;
                            bestSequenceSum = currentSum;


                            resultDNA = originalDNA;
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{string.Join(" ", resultDNA)}");


        }

        private static int SumAllOnes(string[] originalDNA)
        {
            int counter = 0;
            foreach(string symbol in originalDNA)
            {
                if(symbol == "1")
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}