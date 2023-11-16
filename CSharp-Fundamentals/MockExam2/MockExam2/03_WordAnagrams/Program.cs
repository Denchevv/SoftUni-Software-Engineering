namespace _03_WordAnagrams
{
    public class Program
    {
        public static void Main()
        {
            string anagram = Console.ReadLine();
            int countOfWords = int.Parse(Console.ReadLine());
            char[] anagramArr = anagram.ToCharArray();
            Array.Sort(anagramArr);


            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                char[] secondAnagramArr = word.ToCharArray();
                Array.Sort(secondAnagramArr);
                bool isDifferent = false;
                for (int j = 0; j < word.Length; j++)
                {
                    
                    if (anagramArr[j] != secondAnagramArr[j])
                    {
                        isDifferent = true;
                        break;
                    }
                    
                }
                if (!isDifferent)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }

        }

    }
}