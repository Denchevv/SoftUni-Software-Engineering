namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string originalText = Console.ReadLine();
            int startIndex = 0;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymb = input[i];
                for (int j = startIndex; j < originalText.Length; j++)
                {
                    char orignalSymb = originalText[j];
                    if (currentSymb == orignalSymb)
                    {
                        originalText = originalText.Remove(j, 1);
                        startIndex = j;
                        break;
                    }
                }
            }
            Console.WriteLine(originalText);
        }
    }
}