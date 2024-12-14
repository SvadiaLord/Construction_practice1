using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassCource
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string Instructor { get; set; }

        public void ClassCourse(string courseName, int credits, string instructor)
        {
            CourseName = courseName;
            Credits = credits;
            Instructor = instructor;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Курс: {CourseName}, Кредиты: {Credits}, Преподаватель: {Instructor}");
        }
    }
}
