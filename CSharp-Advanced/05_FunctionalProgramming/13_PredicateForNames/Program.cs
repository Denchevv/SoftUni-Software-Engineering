namespace _13_PredicateForNames
{
    public class Program
    {
        public static void Main()
        {
            int possibleLength = int.Parse(Console.ReadLine());
            
            Predicate<int> predicate = x => possibleLength >= x;

            string[] names = Console.ReadLine().Split().Where(n => predicate(n.Length)).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
                
        }
    }
}
