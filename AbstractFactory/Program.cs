using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.name}\n");
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.name}\n");
            Console.WriteLine(pizza.ToString());

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine($"Mary ordered a {pizza.name}\n");
            Console.WriteLine(pizza.ToString());

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine($"Joe ordered a {pizza.name}\n");
            Console.WriteLine(pizza.ToString());
        }
    }
}