using System;
using System.Collections.Generic;
using System.Text;

namespace Task0111
{
    internal class Product
    {
        public Product(string name, double price = 10)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name;
        public double Price;
    }
}
