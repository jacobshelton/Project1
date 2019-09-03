using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        public int ID { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double Price { get; set; }
     
    }
}