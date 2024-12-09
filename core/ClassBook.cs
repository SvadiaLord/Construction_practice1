using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public ClassBook() { }
        public ClassBook(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Страница: {Pages}");
        }
    }
}
