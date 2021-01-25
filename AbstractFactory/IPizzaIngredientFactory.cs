namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}