namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string substring = "bla";

            substring = new string(substring.ToCharArray().Reverse().ToArray());
            
            Console.WriteLine(substring);
        }
    }
}