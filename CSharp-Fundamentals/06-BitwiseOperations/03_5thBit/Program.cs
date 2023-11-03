namespace _03_5thBit
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int shiftedNumber = number >> position;
            int result = shiftedNumber & 1;

            Console.WriteLine(result);
        }
    }
}