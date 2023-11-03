namespace _02_BitAtPosition1
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int shiftedNumber = number >> 1;
            int result = shiftedNumber & 1;

            Console.WriteLine(result);
        }
    }
}