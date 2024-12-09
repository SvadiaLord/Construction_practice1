using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public ClassPerson() { }
        public ClassPerson(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}
