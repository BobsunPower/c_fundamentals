using System;

namespace x02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(", "); int n = int.Parse(Console.ReadLine());
            string title = data[0]; string content = data[1]; string author = data[2];
            Article article = new Article(title, content, author);
            for (int i = 0; i < n; i++) {
                string[] cmd = Console.ReadLine().Split(": ");
                string act = cmd[0]; string tsk = cmd[1];
                if (act == "Edit") {article.Edit(tsk);}
                else if (act == "ChangeAuthor") {article.ChangeAuthor(tsk);}
                else if (act == "Rename") {article.Rename(tsk);}}
            Console.WriteLine(article);
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
        public void Edit(string content)
        {Content = content;}
        public void ChangeAuthor(string author)
        {Author = author;}
        public void Rename(string title)
        {Title = title;}
        public override string ToString()
        {return $"{Title} - {Content}: {Author}";}
    }
}
