using ExercicioPropostoComposicoes.Entities;
using ExercicioPropostoComposicoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoComposicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = CreateClient();
            var order = CreateOrder(client);
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }

        public static Client CreateClient()
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDay);
            return client; 
        }

        public static Product CreateProduct()
        {
            Console.Write("Product name: ");
            string name = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product product = new Product(name, price);
            return product;
        }

        public static List<OrderItem> CreateItems(int quantity)
        {
            List<OrderItem> items = new List<OrderItem>();
            
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                var product = CreateProduct();
                Console.Write("Quantity: ");
                int quantityItems = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantityItems, product);
                items.Add(orderItem);
            }
            return items;
        }

        public static Order CreateOrder(Client client)
        {

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int itemsQuantity = int.Parse(Console.ReadLine());
            var items = CreateItems(itemsQuantity);
            Order order = new Order(orderStatus, client);
            foreach(OrderItem i in items)
            {
                order.AddItem(i);
            }
            return order;
        }
    }
}
