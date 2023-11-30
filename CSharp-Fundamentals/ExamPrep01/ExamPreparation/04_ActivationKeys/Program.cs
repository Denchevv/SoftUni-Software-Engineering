namespace _04_ActivationKeys
{
    public class Program
    {
        public static void Main()
        {
            string key = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Generate")
                {
                    break;
                }

                string[] token = input.Split(">>>");

                string command = token[0];

                if(command == "Contains")
                {
                    string substring = token[1];
                    if(key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                if (command == "Flip")
                {
                    string letterCase = token[1];
                    int startIndex = int.Parse(token[2]);
                    int endIndex = int.Parse(token[3]);

                    int length = endIndex - startIndex;
                    string originalSubstring = key.Substring(startIndex,length);
                    string modifiedSubstring = string.Empty;

                    if (letterCase == "Upper")
                    {
                        modifiedSubstring = originalSubstring.ToUpper();
                    }
                    else if(letterCase == "Lower")
                    {
                        modifiedSubstring = originalSubstring.ToLower();
                    }

                    key = key.Replace(originalSubstring, modifiedSubstring);

                    Console.WriteLine(key);
                }
                if (command == "Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    int length = endIndex - startIndex;

                    key = key.Remove(startIndex,length);

                    Console.WriteLine(key);

                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}