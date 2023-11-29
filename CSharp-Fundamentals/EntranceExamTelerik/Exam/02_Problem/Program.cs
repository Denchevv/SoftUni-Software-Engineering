
namespace _02_Problem
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = string.Empty;


            if(input.Length >= 2)
            {
                bool isPascal = IsTheWordPascalCase(input);
                bool isElephant = IsTheWordElephant(input);     
            }
            else
            {
                bool isConstant = IsTheWordConstant(input);
                bool isField = IsTheWordField(input);
            }
          
         
            if (isConstant)
            {
                result = "constant";
            }
            else if (isField)
            {
                result = "field";
            }
            else if (isPascal)
            {
                result = "pascal";
            }
            else if (isElephant)
            {
                result = "elephant";
            }
            else
            {
                result = "mismatch";
            }

            Console.WriteLine(result);
        }

        private static bool IsTheWordElephant(string input)
        {
            char startingLetter = input[0];
            int startUpperIndex = -1;

            if (!char.IsLower(startingLetter))
            {
                return false;
            }

            for (int i = 1; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if (!char.IsLower(currentLetter))
                {
                    startUpperIndex = i;
                    if (currentLetter == input.Length - 1)
                    {
                        return false;
                    }
                    break;
                }
            }


            for (int i = startUpperIndex; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if (!char.IsUpper(currentLetter))
                {
                    return false;
                }
            }
            return true;
        }


        private static bool IsTheWordPascalCase(string input)
        {
            char startingLetter = input[0];

            if (!char.IsUpper(startingLetter))
            {
                return false;
            }

            for (int i = 1; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if (!char.IsLower(currentLetter))
                {
                    return false;
                }

            }
            return true;
        }

        public static bool IsTheWordField(string input)
        {
            foreach (char symbol in input)
            {
                if (!char.IsLower(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsTheWordConstant(string input)
        {
            foreach (char symbol in input)
            {
                if (!char.IsUpper(symbol))
                {
                    return false;
                }
            }
            return true;
        }
    }
}





