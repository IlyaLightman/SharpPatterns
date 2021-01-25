using System;

namespace AbstractFactory
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }

        public override string ToString()
        {
            return $"Pizza with {dough?.Title}, {sauce?.Title} and {cheese?.Title}";
        }
    }
    
    public class PepperoniClamPizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;

        public PepperoniClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();
            pepperoni = ingredientFactory.CreatePepperoni();
        }
        
        public override string ToString()
        {
            return $"Pizza with {dough?.Title}, {sauce?.Title}, {cheese?.Title}, {pepperoni?.Title} and {clam?.Title}\n";
        }
    }
}