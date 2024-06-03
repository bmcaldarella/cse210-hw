using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Lisheen St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Almeria St", "Vancouver", "BC", "Canada");

            Customer customer1 = new Customer("Brandon Caldarella", address1);
            Customer customer2 = new Customer("Carolat Smith", address2);

            Product product1 = new Product("Laptop", "A123", 999.99, 1);
            Product product2 = new Product("Mouse", "B456", 25.50, 2);
            Product product3 = new Product("Keyboard", "C789", 45.75, 1);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
