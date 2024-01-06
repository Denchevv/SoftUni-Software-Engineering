namespace _08_W3School
{
    public class Program
    {
        static void Main()
        {
            List<int> numbers
                = new List<int>();
            for (int i = 0; i < 3;  i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
