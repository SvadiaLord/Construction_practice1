using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Construction_practice1.core
{
    internal class ClassCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public ClassCar() { }
        public ClassCar(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Make}, Модель: {Model}, Год выпуска: {Year}");
        }
    }
}
