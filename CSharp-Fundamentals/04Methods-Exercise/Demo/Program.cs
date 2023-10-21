namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "hello";
            string reversed = "";
            foreach (char c in input)
            {
                reversed = c + reversed;
            }
            Console.WriteLine(reversed); // Output: "olleh"


        }
    }
}