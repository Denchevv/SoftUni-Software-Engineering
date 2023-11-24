namespace _17_RageQuit
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();

            string result = string.Empty;
            string currentResult = string.Empty;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymb = input[i];
                if (char.IsDigit(currentSymb))
                {                   
                    int numMultiplyer = int.Parse(currentSymb.ToString());
                    currentResult = currentResult;

                    for (int j = 0; j < numMultiplyer; j++)
                    {
                        result += currentResult;
                    }

                    currentResult = string.Empty;
                    
                }
                else
                {
                    if (!result.Contains(currentSymb))
                    {
                        counter++;
                    }
                    currentResult += currentSymb;
                }
            }   

            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine(result);
        }
    }
}