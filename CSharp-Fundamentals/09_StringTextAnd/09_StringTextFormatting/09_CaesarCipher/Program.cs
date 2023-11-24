namespace _09_CaesarCipher
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i< input.Length; i++)
            {
                int newSymbolIndex = input[i] + 3;
                char newSymbol = (char)newSymbolIndex;
                result += newSymbol;
            }

            Console.WriteLine(result);
        }
    }
}