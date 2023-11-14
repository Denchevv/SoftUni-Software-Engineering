namespace _16_Article2._0
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

            List<Article> articles = new List<Article>();
            int range = int.Parse(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                string[] data = Console.ReadLine().Split(",");
                string title = data[0];
                string content = data[1];
                string author = data[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string command = Console.ReadLine();


            if (command == "title")
            {
                articles = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (command == "content")
            {
                articles = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else if (command == "author")
            {
                articles = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}