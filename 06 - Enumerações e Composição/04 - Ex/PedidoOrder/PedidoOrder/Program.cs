using System;
using System.Globalization;
using PedidoOrder.Entities;
using PedidoOrder.Entities.Enums;

namespace PedidoOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + client.Name + " (" + client.BirthDate.ToString("dd/MM/yyyy") + ") - " + client.Email);

            Console.WriteLine("Order items:");

            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine(
                    item.Product.Name
                    + ", $"
                    + item.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantity: "
                    + item.Quantity
                    + ", Subtotal: $"
                    + item.SunTotal().ToString("F2", CultureInfo.InvariantCulture)
                );
            }

            Console.WriteLine("Total price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
