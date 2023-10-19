namespace _03CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char startingSymb = char.Parse(Console.ReadLine());
            char endingSymb = char.Parse(Console.ReadLine());

            string result = PrintCharactersFromRange(startingSymb, endingSymb);

            Console.WriteLine(result);

        }
        public static string PrintCharactersFromRange(char startingSymbol, char endingSymbol)
        {
            //int starting = startingSymbol > endingSymbol ? endingSymbol : startingSymbol;
            
            if (startingSymbol > endingSymbol)
            {
                char tempChar = endingSymbol;
                endingSymbol = startingSymbol;
                startingSymbol = tempChar;
            }

            

            string result = string.Empty;

            for (int i = startingSymbol + 1; i < endingSymbol; i++)
            {
                result += (char)i + " ";
            }

            return result;
        }
    }
}