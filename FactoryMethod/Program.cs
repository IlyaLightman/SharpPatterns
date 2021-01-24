using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.getName()}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.getName()}\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine($"Mary ordered a {pizza.getName()}\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Joe ordered a {pizza.getName()}\n");
        }
    }
}