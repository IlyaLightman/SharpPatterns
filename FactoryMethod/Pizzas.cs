using System;

namespace FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            
            toppings.Add("Grated Reggiano Cheese");
        }
    }
    
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Pe-pe-pepperoni dough";
            sauce = "Pe-pe-pe-pepperoni sauce";
            
            toppings.Add("Pepperoni cheese");
        }
    }
    
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Sauce and Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            
            toppings.Add("Shredded Mozzarella Cheese");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Thick Crust Dough";
            sauce = "Tomato Sauce";
            
            toppings.Add("Shredded Mozzarella Cheese");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into circle (?) slices");
        }
    }
}