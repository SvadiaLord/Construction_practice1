using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassStudent
    {
        public string Name { get; set; }
        public string Garde { get; set; }
        public int ID { get; set; }


        public ClassStudent() { }
        public ClassStudent(string name, string garde, int id)
        {
            Name = name;
            Garde = garde;
            ID = id;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Группа: {Garde}; ID: {ID}");
        }
    }
}
