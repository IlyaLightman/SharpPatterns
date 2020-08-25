using System;

namespace Strategy
{
    internal static class Program
    {
        private static void Main()
        {
            // Паттерн Стратегия!

            Duck mallard = new MallardDuck();

            // Вызов метода performQuack(), унаследованного классом MallardDuck;
            // метод делегирует выполнение операции по ссылке на QuackBehavior
            // (то есть вызывает quack() через унаследованную переменную quackBehavior)
            mallard.PerformQuack();
            // Затем то же самое происходит с методом performFly(), также унаследованным классом MallardDuck
            mallard.PerformFly();

            Duck model = new ModelDuck();
            
            // Первый вызов performFly() передаётся реализации, заданной в конструкторе...
            // ...ModelDuck - то есть экземпляру FlyNoWay
            model.PerformFly();
            // Утка-приманка вдруг взлетает на рекативном двигателе!
            model.FlyBehavior = new FlyRocketPowered();
            // Способность утки-приманки к полёту переключается динамически!
            // Если бы реализация находилась в иерархии Duck, такое было бы невозможно
            model.PerformFly();

            Console.Read();
        }
    }
}