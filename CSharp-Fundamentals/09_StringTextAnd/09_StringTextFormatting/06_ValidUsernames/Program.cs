namespace _06_ValidUsernames
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(',', ' ');

            foreach (var pass in input)
            {
                bool correctLength = HasCorrectLength(pass);
                bool correctFormat = HasCorrectFormat(pass);
                bool noRedundance = HasNoRedundantSpace(pass);

                if(correctLength && correctFormat && noRedundance)
                {
                    Console.WriteLine(pass);
                }

            }
        }

        private static bool HasNoRedundantSpace(string pass)
        {
            if(!pass.Contains(' '))
            {
                return true;
            }
            return false;
        }

        public static bool HasCorrectFormat(string pass)
        {
            foreach (char symbol in pass)
            {
                if (!(char.IsLetterOrDigit(symbol)) && symbol != '_' && symbol != '-')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool HasCorrectLength(string pass)
        {
           return pass.Length >= 3 && pass.Length <= 16 ? true: false;

        }
    }
}