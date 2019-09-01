using PizzaBox.Domain.Models;
using System.Collections.Generic;

namespace PizzaBox.Domain.Abstract
{
    public abstract class APizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<Topping> Toppings {get; set;}
    }
}