using System;
using System.Collections.Generic;
//using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<Topping> Toppings {get; set;}
    }
}