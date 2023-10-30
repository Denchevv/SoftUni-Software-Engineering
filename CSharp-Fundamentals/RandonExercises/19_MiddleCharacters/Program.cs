namespace _19_MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
           
            PrintMiddleSymbol(text);
        }
        static void PrintMiddleSymbol(string text) 
        {
            int indexToPrint = text.Length / 2;
            char firstMiddle = text[indexToPrint];
            char secondMiddle = text[indexToPrint];
            if (text.Length % 2 == 0)
            {
                firstMiddle = text[indexToPrint-1];
                Console.WriteLine($"{firstMiddle}{secondMiddle}");
            }
            else
            {
                Console.WriteLine(firstMiddle);
            }
        }
    }
}