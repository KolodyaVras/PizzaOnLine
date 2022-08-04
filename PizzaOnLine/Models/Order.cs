using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOnLine.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderPosition> OrderPositions { get; set; }
        public Order()
        {
            OrderPositions = new List<OrderPosition>();
        }
    }
}