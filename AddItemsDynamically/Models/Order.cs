using System;
using System.Collections.Generic;

namespace AddItemsDynamically.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsUrgent { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime Created { get; set; }
    }
}
