﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioSec123.Entities
{
    class OrderItem
    {
        public int Quantity { get; }
        public double Price { get; }
        public Product Product { get; set; } = new Product();

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Price.ToString("F2"));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal().ToString("F2"));

            return sb.ToString();
        }
    }
}
