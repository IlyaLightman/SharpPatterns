using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {name} ");
            Console.WriteLine("Tossing dough.... ");
            Console.WriteLine("Adding sauce.... ");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in toppings)
            {
                Console.WriteLine($"- {topping}");
            }
        }

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

        public string getName()
        {
            return name;
        }
    }
}