namespace Decorator
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string Description()
        {
            return description;
        }

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description();
    }
}