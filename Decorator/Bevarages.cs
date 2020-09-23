namespace Decorator
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
    
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
    
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
    
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}