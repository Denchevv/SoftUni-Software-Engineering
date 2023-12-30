namespace _03_LineNumbers2
{
    public class Program
    {
        public static async Task Main()
        {
            string[] text = await File.ReadAllLinesAsync("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = $"{i + 1}. {text[i]}";
            }

            await File.WriteAllLinesAsync("output.txt", text);
        }
    }
}
