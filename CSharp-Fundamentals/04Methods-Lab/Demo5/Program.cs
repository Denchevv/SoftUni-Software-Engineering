namespace Demo5
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string result = RepeatString(text, repeats);
            Console.WriteLine(result);

        }
        public static string RepeatString(string text, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result += text;
            }
            return result;
        }
    }
}