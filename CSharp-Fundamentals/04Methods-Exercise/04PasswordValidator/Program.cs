using System.Security.Cryptography.X509Certificates;

namespace _04PasswordValidator
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();

            bool isCorrectLength = PasswordLengthCheck(input);

            if (!isCorrectLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool passHasDigitOrLetter = DoesItConsistLetterAndDigitsOnly(input);


            if (!passHasDigitOrLetter)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }


            bool hasMinTwoDigits = HaveEnoughDigits(input);

            if (!hasMinTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isCorrectLength && passHasDigitOrLetter && hasMinTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool PasswordLengthCheck(string password)
        {
            return password.Length >= 6 && password.Length <= 10 ? true : false;

        }
        public static bool DoesItConsistLetterAndDigitsOnly(string password)
        {
            
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool HaveEnoughDigits(string password)
        {
            int counterOfDigits = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    counterOfDigits++;
                }
            }

            return counterOfDigits >= 2 ? true : false;
            /*if (counterOfDigits < 2)
            {
                return false;
            }
            return true;*/

        }
    }
}

