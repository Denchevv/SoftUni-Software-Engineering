namespace _08_ExtractFile
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] substractedText = input[input.Length - 1].Split('.');

            string fileName = substractedText[0];
            string extension = substractedText[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}