using Pedidos_Composition.Entities;
using Pedidos_Composition.Entities.Enums;
using System;
using System.Globalization;

namespace Pedidos_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD / MM / YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order ordem = new Order(DateTime.Now, status, c);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(product, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem ordemItem = new OrderItem(quantity, price, p);

                ordem.AddItem(ordemItem);
            }
            Console.WriteLine();
            Console.WriteLine(ordem);

        }
    }
}
