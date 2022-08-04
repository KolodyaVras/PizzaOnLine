using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOnLine.Models
{
    public class OrderPosition
    {

        public int OrderPositionId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int PizzaCount { get; set; }
    }
}