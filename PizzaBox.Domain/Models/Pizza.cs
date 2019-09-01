using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstract;

namespace PizzaBox.Domain.Models
{
    public class Pizza : APizza
    {
        public override string ToString()
        {
            return $"{Size.Name} {Crust.Name} {Toppings.GetRange(0, Toppings.Count-1)}";
        }
        
        //cost
        //public double Price {get; set;}

        //2 default toppings
        //toppings limit 5
    }
}