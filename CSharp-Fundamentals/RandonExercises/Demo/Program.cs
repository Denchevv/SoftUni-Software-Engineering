namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    Console.WriteLine(false);
                    return;
                }
            }
            Console.WriteLine(true);
        }
    }
}