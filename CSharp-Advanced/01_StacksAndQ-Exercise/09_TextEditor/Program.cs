using System.Collections.Generic;
using System.Xml.Linq;

namespace _09_TextEditor
{
    public class Program
    {
        public static void Main()
        {
            int cmdCount = int.Parse(Console.ReadLine());

            string result = string.Empty;
            Stack<string> arguments = new Stack<string>();
            Stack<string> commandsOrder = new Stack<string>();


            for (int i = 0; i < cmdCount; i++)
            {
                string[] token = Console.ReadLine().Split();
                string command = token[0];

                switch (command)
                {
                    case "1":
                        string argument = token[1];
                        arguments.Push(result);
                        commandsOrder.Push("1");
                        result += argument;
                        break;
                    case "2":
                        int countToDelete = int.Parse(token[1]);                  
                        arguments.Push(result);
                        commandsOrder.Push("2");
                        result = result.Substring(0, result.Length - countToDelete);
                        break;
                    case "3":
                        int index = int.Parse(token[1]);
                        Console.WriteLine(result[index-1]);
                        break;
                    case "4":                   
                            result = arguments.Pop();
                        break;
                }
            }
        }
    }
}
