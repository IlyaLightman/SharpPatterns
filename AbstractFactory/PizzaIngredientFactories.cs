namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        
        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
    
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ChicagoDough();
        }
        
        public Sauce CreateSauce()
        {
            return new ChicagoSauce();
        }
        
        public Cheese CreateCheese()
        {
            return new ChicagoCheese();
        }
        
        public Pepperoni CreatePepperoni()
        {
            return new ChicagoPepperoni();
        }
        
        public Clams CreateClam()
        {
            return new ChicagoClams();
        }
    }
}