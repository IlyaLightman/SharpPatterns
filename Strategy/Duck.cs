using System;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public Duck() { }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.ToFly();
        }

        public void PerformQuack()
        {
            QuackBehavior.ToQuack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay(); // Утка-приманка изначально летать не умеет...
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }

    public interface IFlyBehavior // Интерфейс реализуется всеми классами
    {
        void ToFly();
    }

    public class FlyWithWings : IFlyBehavior // Реализация поведения для уток, которые умеют летать
    {
        public void ToFly()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class FlyNoWay : IFlyBehavior // Реализация поведения для утрок, которые не летают
    {
        public void ToFly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void ToFly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }

    public interface IQuackBehavior
    {
        void ToQuack();
    }

    public class Quack : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void ToQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}