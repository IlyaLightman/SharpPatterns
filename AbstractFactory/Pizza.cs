using System;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string name { get; set; }
        
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }


        public override string ToString()
        {
            return "Pizza with nothing";
        }
    }
}