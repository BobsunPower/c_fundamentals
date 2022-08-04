using System;
using System.Collections.Generic;
using System.Linq;

namespace x03.Articles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> art = new List<Article>();
            for (int i = 0; i < n; i++) {string[] data = Console.ReadLine().Split(", ");
                string title = data[0]; string content = data[1]; string author = data[2];
                art.Add(new Article(title, content, author));}
            string type = Console.ReadLine();
            if (type == "title") {art = art.OrderBy(t => t.Title).ToList();}
            else if (type == "content") {art = art.OrderBy(c => c.Content).ToList();}
            else if (type == "author") {art = art.OrderBy(a => a.Author).ToList();}
            foreach (Article a in art) {Console.WriteLine(a);}
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
        public string Title {get; set;}
        public string Content {get; set;}
        public string Author {get; set;}
        public override string ToString()
        {return $"{Title} - {Content}: {Author}";}
    }
}
