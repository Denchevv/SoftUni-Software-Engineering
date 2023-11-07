namespace 02_Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>()
            {
               "one", "one1", "one1","one1"
            };
            Console.WriteLine(string.Join(" ", list));
        }

    }
}