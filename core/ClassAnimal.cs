using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassAnimal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public ClassAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Вид: {Species}");
        }
    }
}
