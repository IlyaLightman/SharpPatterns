namespace AbstractFactory
{
    public abstract class Dough
    {
        public abstract string Title { get; }
    }

    public abstract class Sauce
    {
        public abstract string Title { get; }
    }

    public abstract class Cheese
    {
        public abstract string Title { get; }
    }

    public abstract class Pepperoni
    {
        public abstract string Title { get; }
    }

    public abstract class Clams
    {
        public abstract string Title { get; }
    }

    public class ThinCrustDough : Dough
    {
        public override string Title { get; } = "Thin Crust Dough";
    }

    public class MarinaraSauce : Sauce
    {
        public override string Title { get; } = "Marinara Souce";
    }

    public class ReggianoCheese : Cheese
    {
        public override string Title { get; } = "Reggiano Cheese";
    }

    public class SlicedPepperoni : Pepperoni
    {
        public override string Title { get; } = "Sliced Pepperoni";
    }

    public class FreshClams : Clams
    {
        public override string Title { get; } = "Fresh Clams";
    }

    public class ChicagoDough : Dough
    {
        public override string Title { get; } = "Chicago Dough";
    }

    public class ChicagoSauce : Sauce
    {
        public override string Title { get; } = "Chicago Sauce";
    }

    public class ChicagoCheese : Cheese
    {
        public override string Title { get; } = "Chicago Cheese";
    }

    public class ChicagoPepperoni : Pepperoni
    {
        public override string Title { get; } = "Chicago Pepperoni";
    }

    public class ChicagoClams : Clams
    {
        public override string Title { get; } = "Chicago Clams";
    }
}