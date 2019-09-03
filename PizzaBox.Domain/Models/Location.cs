using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Address {get; set;}
        public List<Order> Orders {get; set;}
    }
}