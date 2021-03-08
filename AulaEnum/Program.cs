using AulaEnum.Entities;
using AulaEnum.Entities.Enums;
using System;

namespace AulaEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}

