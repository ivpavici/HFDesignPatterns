using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;

namespace StrategyPattern
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new RealQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
