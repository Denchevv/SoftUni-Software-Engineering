namespace _15_Article
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

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
      
    }

    public class Program
    {
        public static void Main()
        {
            string[] data = Console.ReadLine().Split(",");

            string title = data[0];
            string content = data[1];
            string author = data[2];

            Article article = new Article(title, content, author);

            int range = int.Parse(Console.ReadLine());
            for (int i = 0; i < range; i++)
            {
                string[] data2 = Console.ReadLine().Split(":");
                string command = data2[0];
                string name = data2[1];

                if (command == "Edit")
                {
                    article.Edit(name);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(name);
                }
                else if (command == "Rename")
                {
                    article.Rename(name);
                }
            }
            Console.WriteLine(article);
        }
    }
}