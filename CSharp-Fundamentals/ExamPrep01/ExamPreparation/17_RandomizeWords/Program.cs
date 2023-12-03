namespace _17_RandomizeWords
{
    public class Program
    {
        public static void Main()
        {
            Random random = new Random();

            string[] words = Console.ReadLine().Split();

            for (int position1 = 0; position1 < words.Length; position1++)
            {
                int position2 = random.Next(words.Length);

                string temp = words[position1];
                words[position1] = words[position2];
                words[position2] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}