using System;
using Enumeração.Entities;
using Enumeração.Entities.Enum;

namespace Enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            Order p1 = new Order()
            {
                Id = 6186,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing

            };

            Console.WriteLine(p1);

            string order = OrderStatus.Processing.ToString();
            Console.WriteLine(order);
            string digite = Console.ReadLine();
            OrderStatus c = Enum.Parse<OrderStatus>(digite);
            Console.WriteLine(c);

        }
    }
}
