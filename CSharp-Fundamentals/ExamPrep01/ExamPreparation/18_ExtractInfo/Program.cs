namespace _18_ExtractInfo
{
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 0; i < range; i++)
            {
                string text = Console.ReadLine();

                int startNameIndex = text.IndexOf('@') + 1;
                int endNameIndex = text.LastIndexOf('|');

                int startAgeIndex = text.IndexOf('#') + 1;
                int endAgeIndex = text.LastIndexOf('*');

                string name = text.Substring(startNameIndex, endNameIndex - startNameIndex);
                string age = text.Substring(startAgeIndex, endAgeIndex - startAgeIndex);

                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
