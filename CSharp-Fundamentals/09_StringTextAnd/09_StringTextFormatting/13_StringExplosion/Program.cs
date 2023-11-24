namespace _13_StringExplosion
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '>')
                {
                    int power = int.Parse(input[i + 1].ToString());

                        if (input[i] == '>')
                        {
                            power++;
                        }
                    }
                }
              
                    result += input[i];              

            }
        }
    }
}