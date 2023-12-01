namespace _09_Article2
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    public class Program
    {
        public static void Main()
        {
            {
                int number = int.Parse(Console.ReadLine());
                List<Article> list = new List<Article>();

                for (int i = 0; i < number; i++)
                {
                    string[] data = Console.ReadLine().Split(", ");

                    string title = data[0];
                    string content = data[1];
                    string author = data[2];

                    Article article = new Article(title, content, author);

                    list.Add(article);
                }

                list.ForEach(a => { Console.WriteLine(a); });


            }
        }
    }
}