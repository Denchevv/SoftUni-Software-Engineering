namespace _03ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length / 2; i++) 
            { 
                string firstText = text[i];
                int reversedIndex = text.Length - 1 - i;

                text[i] = text[reversedIndex];
                text[reversedIndex] = firstText;
                
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}