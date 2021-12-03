using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            Article articles = new Article();
            string[] article = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            articles.Title = article[0];
            articles.Content = article[1];
            articles.Author = article[2];

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                string[] commandArgs = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];
                string newMaterial = commandArgs[1];


                if (action == "Edit")
                {
                    articles.Edit(articles.Content, newMaterial);
                }
                else if (action == "ChangeAuthor")
                {
                    articles.ChangeAuthor(articles.Author, newMaterial);
                }
                else if (action == "Rename")
                {
                    articles.Rename(articles.Title, newMaterial);
                }
            }
            articles.ToString(articles.Title, articles.Content, articles.Author);
        }
    }
    class Article
    {
        public string Title;
        public string Content;
        public string Author;

        public string Edit(string oldContent, string newContent)
        {
            Content = newContent;
            return Content;
        }
        public string ChangeAuthor(string oldAuthor, string newAuthor)
        {
            Author = newAuthor;
            return Author;
        }
        public string Rename(string oldTitle, string newTitle)
        {
            Title = newTitle;
            return Title;
        }
        public void ToString(string title, string content, string author)
        {
            Console.WriteLine($"{title} - {content}: {author}");
        }
    }
}
