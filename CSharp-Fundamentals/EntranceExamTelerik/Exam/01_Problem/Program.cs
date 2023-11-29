using System.Linq;

namespace _01_Problem

{
    public class Program
    {
        public static void Main()
        {
            string question = Console.ReadLine();

            string result = string.Empty;

            while (question != "bye")
            {
                if (question.Length % 2 == 0)
                {
                    for (int i = 0; i < question.Length; i += 2)
                    {
                        result += question[i];

                    }
                }
                else
                {
                    for (int i = 1; i < question.Length; i += 2)
                    {
                        string reversedString = new string(question.ToCharArray().Reverse().ToArray());

                        result += reversedString[i];

                    }
                }

                Console.WriteLine(result);
                result = "";
                question = Console.ReadLine();
            }

        }
    }
}