namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    result+= input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}