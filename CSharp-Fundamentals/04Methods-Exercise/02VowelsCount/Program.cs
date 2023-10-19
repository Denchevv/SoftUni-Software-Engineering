namespace _02VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int result = GetVowelsQuantity(text);

            Console.WriteLine(result);

        }
        public static int GetVowelsQuantity(string text)
        {
            int numberSumOfVowels = 0;
            foreach (char letters in text)
            {
                char lowerCaseLetter = char.ToLower(letters);

                numberSumOfVowels += "aeiou".Contains(lowerCaseLetter) ? 1 : 0;

               /* numberSumOfVowels += (lowerCaseLetter == 'a'
                                    || lowerCaseLetter == 'e'
                                    || lowerCaseLetter == 'i'
                                    || lowerCaseLetter == 'o'
                                    || lowerCaseLetter == 'u')
                                    ? 1 : 0;*/

            }

            return numberSumOfVowels;

        }

    }
}