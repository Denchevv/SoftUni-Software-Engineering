namespace _15_StringExplosion3
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int strentgh = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strentgh += int.Parse(input[i + 1].ToString());
                    continue;
                }
                else
                {
                    if(strentgh > 0)
                    {
                        input = input.Remove(i, 1);
                        strentgh--;
                        i--;
                    }                  
                }
            }
            Console.WriteLine(input);
        }
    }
}