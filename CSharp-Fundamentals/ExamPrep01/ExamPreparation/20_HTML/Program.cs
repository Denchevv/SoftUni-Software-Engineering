namespace _20_HTML
{
    public class Program
    {
        public static void Main()
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comments = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");


            while (comments != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comments}");
                Console.WriteLine("</div>");

                comments = Console.ReadLine();
            }
        }
    }
}
