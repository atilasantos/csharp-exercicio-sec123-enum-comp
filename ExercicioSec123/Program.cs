using ExercicioSec123.Entities;
using ExercicioSec123.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioSec123
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client data
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            //Order data
            Console.Write("Enter order data:\nStatus: ");
            string mockStatus = Console.ReadLine();

            OrderStatus status = Enum.Parse<OrderStatus>(mockStatus); // Converting to enum
            Console.Write("How many items to this order?");
            int itemsQuantity = Convert.ToInt32(Console.ReadLine());

            //Instantiating order, product, order item
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 0; i < itemsQuantity; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = Convert.ToInt32(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine(order);



        }
    }
}
