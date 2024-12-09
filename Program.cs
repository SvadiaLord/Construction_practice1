using Construction_practice1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClassPerson classPerson = new ClassPerson(17, "Leha");
            classPerson.DisplayInfo();

            ClassCar classCar = new ClassCar("Lada", "Kalina", 1986);
            classCar.DisplayInfo();

            ClassBook classBook = new ClassBook("Магическая Битва: Satory ГОЙДА Edition", "Гена Цидармян", 666);
            classBook.DisplayInfo();

            ClassRectangle classRectangle = new ClassRectangle(100, 200);
            classRectangle.DisplayInfo();

            ClassCircle classCircle = new ClassCircle(100);
            classCircle.DisplayInfo();

            ClassStudent classStudent = new ClassStudent("Leha", "П23-2.1", 23678778);
            classStudent.DisplayInfo();

        }
    }
}
