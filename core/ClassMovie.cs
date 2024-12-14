using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassMovie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }

        public ClassMovie(string title, string director, int releaseYear)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Режиссер: {Director}, Год выпуска: {ReleaseYear}");
        }
    }
}
