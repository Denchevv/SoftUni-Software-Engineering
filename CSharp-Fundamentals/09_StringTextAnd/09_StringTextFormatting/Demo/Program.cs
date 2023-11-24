namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            char letter = char.Parse(Console.ReadLine()); // Replace 'C' with the letter you want to find the position of
            int position = GetAlphabetPosition(letter);

            Console.WriteLine($"The position of '{letter}' in the alphabet is: {position}");
        }

        public static int GetAlphabetPosition(char letter)
        {
            // Convert the letter to uppercase to handle both uppercase and lowercase letters
            char upperCaseLetter = char.ToUpper(letter);

            // Get the ASCII value of 'A' and subtract it from the ASCII value of the letter
            int position = upperCaseLetter - 'A' + 1;

            return position;
        }
    }

}