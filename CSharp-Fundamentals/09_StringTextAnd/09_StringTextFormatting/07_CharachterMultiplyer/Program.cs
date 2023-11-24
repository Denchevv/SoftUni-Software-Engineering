namespace _07_CharachterMultiplyer
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(',', ' ');

            string word1 = input[0];
            string word2 = input[1];
            int result = 0;

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i <= word1.Length - 1; i++)
                {
                    result += word1[i] * word2[i];
                }
            }
            else
            {
                string shorterString = (word1.Length < word2.Length) ? word1 : word2;
                string longerString = (word1.Length > word2.Length) ? word1 : word2;

                for (int i = 0; i <= shorterString.Length - 1; i++)
                {
                    result += word1[i] * word2[i];
                }

                int startingIndex = shorterString.Length;
                int endIndex = longerString.Length - 1;

                for (int i = startingIndex; i <= endIndex; i++)
                {
                    int currentNum = longerString[i];
                    result += currentNum;
                }
            }
            Console.WriteLine(result);

        }
    }
}