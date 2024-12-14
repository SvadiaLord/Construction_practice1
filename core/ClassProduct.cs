using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice1.core
{
    internal class ClassProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public ClassProduct(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void AddStock(int amount)
        {
            Quantity += amount;
        }

        public void RemoveStock(int amount)
        {
            if (amount <= Quantity)
                Quantity -= amount;
            else
                Console.WriteLine("Недостаточно товара на складе.");
        }
    }
}
