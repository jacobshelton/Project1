using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Pizza : APizza
    {
        public Pizza(Crust crust, Size size, List<Topping> tops)
        {
            Crust = crust;
            Size = size;
            Toppings = tops;
        }

        public override string ToString()
        {
            return $"{Crust} {Size} {Toppings.GetRange(0, Toppings.Count-1)}";
        }
        
        //cost
        //public double Price {get; set;}

        //2 default toppings
        //toppings limit 5
    }
}