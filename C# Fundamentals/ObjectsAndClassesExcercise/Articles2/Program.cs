using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> all = new List<Article>();

            for (int i = 1; i <= n; i++)
            {
                List<string> article = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var articles = new Article(article[0], article[1], article[2]);

                all.Add(articles);

            }


            string command = Console.ReadLine();

            if (command == "title")
            {
                all = all.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                all = all.OrderBy(x => x.Content).ToList();
            }
            else
            {
                all = all.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, all));
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {

            return $"{Title} - {Content}: {Author}";

        }
    }
}
