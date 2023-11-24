namespace _12_ReplaceRepeatingChars
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string result = string.Empty;
            bool isInSequence = false;

            for (int i = 0; i < input.Length-1; i++)
            {

                if (input[i] == input[i + 1])
                {
                    continue;
                }
                else
                {
                    result += input[i];
                }
            }


            Console.WriteLine(result + input[input.Length-1]);
        }
    }
}