using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaManagement.Models
{
    public enum OrderItemType
    {
        Pizza,
        Drink,
        Bread,
        Chicken
    }
    public class OrderItem
    {
        public int ID { get; set; }
        public OrderItemType Type { get; set; }
        public decimal Price { get; set; }

        IEnumerable<OrderItemDetail> OrderITemDetails { get; set; }

    }
}
