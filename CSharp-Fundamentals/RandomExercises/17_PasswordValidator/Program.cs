using System;

namespace _17_PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();

            bool correctLength = IsItCorrectLength(inputPass);
            bool lettersOrDigitsOnly = ConsistLettersAndDigitsOnly(inputPass);
            bool minTwoDigits = HasMinimumTwoDigits(inputPass);

            if (!correctLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (!lettersOrDigitsOnly)
            {
                
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!minTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (correctLength && lettersOrDigitsOnly && minTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool IsItCorrectLength(string password)
        {
            int length = password.Length;
            return length >= 6 && length <= 10 ? true : false;
        }

        static bool ConsistLettersAndDigitsOnly(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasMinimumTwoDigits(string password)
        {
            int counter = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                    if (counter == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}