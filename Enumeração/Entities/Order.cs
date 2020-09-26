using System;
using System.Collections.Generic;
using System.Text;
using Enumeração.Entities.Enum;

namespace Enumeração.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Moment = {Moment.ToString("g")}, Status = {Status}";
        }
    }
}
