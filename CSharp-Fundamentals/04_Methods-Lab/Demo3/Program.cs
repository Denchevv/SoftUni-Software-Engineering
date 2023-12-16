namespace Demo3
{
    internal class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNum, secondNum));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine((char)GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    Console.WriteLine(GetMax(firstStr, secondStr));
                    break;
            }
        }
            public static int GetMax(int a, int b)
            {
                return Math.Max(a, b);
       
            }
            public static char GetMax(char a, char b)
            {
                return (char)Math.Max(a, b);
                
            }
            public static string GetMax(string a, string b)
            {
                int result = a.CompareTo(b);

                if (result > 0)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
        }
    }

