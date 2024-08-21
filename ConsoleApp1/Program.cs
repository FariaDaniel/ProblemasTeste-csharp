using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System;
using System.Collections.Generic;


namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}



/*
    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:

OrderStatus os;
Enum.TryParse("Delivered", out os);
*/