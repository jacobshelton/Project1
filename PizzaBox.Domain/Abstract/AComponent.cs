namespace PizzaBox.Domain.Abstract
{
    public abstract class AComponent
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public double Price {get; set;}
    }
}