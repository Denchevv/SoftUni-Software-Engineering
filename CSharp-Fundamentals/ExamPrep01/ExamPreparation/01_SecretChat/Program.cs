using System.Text;

namespace _01_SecretChat
{
    public class Program
    {
        public static void Main()
        {
            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Reveal")
                {
                    break;
                }

                string[] token = input.Split(":|:");
                string command = token[0];
                
                if(command == "InsertSpace")
                {
                    int index = int.Parse(token[1]);
                    string space = " ";

                    message = message.Insert(index, space);

                    Console.WriteLine(message);
                }
                else if(command == "Reverse")
                {
                    string substring = token[1];

                    if (!message.Contains(substring))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    int startSubstrIndex = message.IndexOf(substring);
                    int endSubsStrIndex = substring.Length;

                    message = message.Remove(startSubstrIndex, endSubsStrIndex);

                    substring = new string(substring.ToCharArray().Reverse().ToArray());

                    message += substring;

                    Console.WriteLine(message);
                  
                }
                else if (command == "ChangeAll")
                {
                    string substring = token[1];
                    string replacement = token[2];

                    message = message.Replace(substring, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}