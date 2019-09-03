using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public List<Order> Orders {get; set;}
    }
}