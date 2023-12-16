namespace _16_CharactersinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
         char start = char.Parse(Console.ReadLine());
         char end = char.Parse(Console.ReadLine());

            PrintSequence(start, end);

        }

        static void PrintSequence (char a, char b)
        {
            char temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a + 1;  i < b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}