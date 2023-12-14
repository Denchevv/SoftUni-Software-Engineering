namespace _19_AsciiSumator
{
    public class Program
    {
        public static void Main()
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int result = 0;

            for (char i = startSymbol; i < endSymbol; i++)
            {
                char currentSymb = i;

                for (int j = 0; j < text.Length; j++)
                {
                    char symbFromText = text[j];

                    if(currentSymb == symbFromText)
                    {
                        result += currentSymb;
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
