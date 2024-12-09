using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ClassRectangle() { }
        public ClassRectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Длина: {Width}, Высота: {Height}");
        }
    }
}
