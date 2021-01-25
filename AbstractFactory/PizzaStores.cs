using System.Xml.XPath;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "New York Style Cheese Pizza";
            }
            else
            {
                pizza = new PepperoniClamPizza(ingredientFactory);
                pizza.name = "New York Style Pepperoni Clam Pizza";
            }

            return pizza;
        }
    }
    
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "Chicago Style Cheese Pizza";
            }
            else
            {
                pizza = new PepperoniClamPizza(ingredientFactory);
                pizza.name = "Chicago Style Pepperoni Clam Pizza";
            }

            return pizza;
        }
    }
}