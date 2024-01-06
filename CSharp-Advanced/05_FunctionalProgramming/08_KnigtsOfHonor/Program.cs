namespace _08_KnigtsOfHonor
{
    public class Program
    {
        public static void Main()
        {
            Action<string> print = word => Console.WriteLine("Sir " + word);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(w => print(w));
        }
    }
}
