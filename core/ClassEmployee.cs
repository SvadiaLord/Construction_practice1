using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public ClassEmployee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void RaiseSalary(decimal percentage)
        {
            Salary += Salary * percentage / 100;
        }
    }
}
