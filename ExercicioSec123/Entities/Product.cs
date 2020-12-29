using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioSec123.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
