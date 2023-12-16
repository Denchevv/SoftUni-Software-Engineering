namespace _07NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            
            PrintMatrix(number);
            
        }


        public static void PrintLine(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }

        public static void PrintMatrix(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                PrintLine(number);
            }



        }
    }
}