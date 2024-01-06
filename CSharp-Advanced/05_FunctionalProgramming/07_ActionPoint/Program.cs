namespace _07_ActionPoint
{
    public class Program
    {
        public static void Main()
        {
            Action<string> print = word => Console.WriteLine(word);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(w => print(w));
        }
    }
}
