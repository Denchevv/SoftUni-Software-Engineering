namespace _16_ChangeLetters
{
    public class Program
    {
        public static void Main()
        {
            //Read Input

            string[] inputArray = Console.ReadLine()
                             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                string currentString = inputArray[i];

                // Substring the number and Parse it to int and getting the letters
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                string currentNum = currentString.Substring(1, currentString.Length - 2);
                double number = double.Parse(currentNum);

                int alphabetPositionFirst = GetAlphabetPosition(firstLetter);
                int alphabetPositionSecond = GetAlphabetPosition(lastLetter);


                if (char.IsUpper(firstLetter))
                {
                    number /= alphabetPositionFirst; // if its upper letter - divide

                }
                else if (char.IsLower(firstLetter))
                {
                    number *= alphabetPositionFirst; // if its lower letter - multiply

                }

                result += number;

                if (char.IsUpper(lastLetter))
                {
                    result -= alphabetPositionSecond; //if uts uppercase - subtract 

                }
                else if (char.IsLower(lastLetter))
                {
                    result += alphabetPositionSecond; // if its lowercaase - add

                }             
            }

            Console.WriteLine($"{result:f2}");

        }

        public static int GetAlphabetPosition(char firstLetter)
        {
            char upperLetter = char.ToUpper(firstLetter);

            int position = upperLetter - 'A' + 1;

            return position;
        }
    }
}