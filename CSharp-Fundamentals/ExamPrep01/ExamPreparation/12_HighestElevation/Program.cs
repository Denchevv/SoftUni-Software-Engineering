namespace _12_HighestElevation
{
    public class Program
    {
        public static void Main()
        {
            int[] input = { 1, 7, 3, 5, 8, 11, 6, 2 };

            int highestElevation = int.MinValue;
            int currentElevation = 0;
            int valleyStart = input[0];
            int peak = 0;
            int valleyEnd = 0;

            for (int i = 1; i < input.Length; i++) 
            {
                int currentNum = input[i];
                int nextNum = input[i + 1];

                if( currentNum < nextNum)
                {
                  if(currentNum < input[i-1])
                    {
                        valleyStart = currentNum;
                    }   
                }
                else if( currentNum > nextNum ) 
                {
                    peak = currentNum;
                    valleyEnd = nextNum;

                    currentElevation = Math.Max(peak - valleyStart, peak - valleyEnd);  
                    
                    if(currentElevation > highestElevation)
                    {
                        highestElevation = currentElevation;
                    }
                }
            }



        }
    }
}