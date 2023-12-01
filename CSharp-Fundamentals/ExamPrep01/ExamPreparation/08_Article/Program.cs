namespace _08_Article
{
    class Article
    {
        public Article (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }
        public string Author { get; set; }

         public void EditContent (string content)
        {
            Content = content;
        } 

        public void ChangeAuthor (string author)
        {
            Author = author;
        }
        public void RenameTitle (string title)
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
            {
                string[] data = Console.ReadLine().Split(", ");
                int number = int.Parse(Console.ReadLine());

                string title= data[0];
                string content= data[1];
                string author= data[2];

                Article article = new Article(title, content, author);

                for (int i = 0; i < number; i++)
                {
                    string[] input = Console.ReadLine().Split(": ");

                    if (input[0] == "Edit")
                    {
                        article.EditContent(input[1]);
                    }
                    else if(input[0] == "ChangeAuthor")
                    {
                        article.ChangeAuthor(input[1]);
                    }
                    else if (input[0] == "Rename")
                    {
                        article.RenameTitle(input[1]);
                    }
                }

                Console.WriteLine(article);

            }
        }
    }
}
