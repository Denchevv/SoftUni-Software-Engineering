namespace _03_Article2._0
{
    public class Program
    {
        public static void Main()
        {
            int countInputs = int.Parse(Console.ReadLine());

            List<Article> articleList = new List<Article>();

            for (int i = 0; i < countInputs; i++)
            {
                string[] properties = Console.ReadLine().Split(", ");

                string title = properties[0];
                string content = properties[1];
                string author = properties[2];
                Article article = new Article(title, content, author);

                articleList.Add(article);
            }
            string sortingProperty = Console.ReadLine();

            if (sortingProperty == "title")
            {
                articleList = articleList
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if(sortingProperty == "content")
            {
                articleList = articleList
                    .OrderBy(x =>x.Content)
                    .ToList();
            }
            else if(sortingProperty == "author")
            {
                articleList = articleList
                    .OrderBy(x=> x.Author)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articleList.Select(x=> $"{x.Title} - " +
                             $"{x.Content}: {x.Author}")));


        }
    }

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


        /*public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }*/
    }

}