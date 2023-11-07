namespace _02_2._RandomizeWords
{
    public class Program
    {
        public static void Main()
        {
            var wordsList = Console.ReadLine().Split().ToList();
            var random = new Random();

            for (int i = 0; i < wordsList.Count; i++) 
            {
                var randomIndex = random.Next(0, wordsList.Count);

                var temp = wordsList[randomIndex];
                wordsList[randomIndex] = wordsList[i];
                wordsList[i] = temp;
            }
            for (int i = 0;i < wordsList.Count;i++)
            {
                Console.WriteLine(wordsList[i]);
            }

        }
    }
}