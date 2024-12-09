using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassCircle
    {
        public int Radius { get; set; }

        public ClassCircle() { }
        public ClassCircle(int radius)
        {
            Radius = radius;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Радиус: {Radius}");
        }
    }
}
