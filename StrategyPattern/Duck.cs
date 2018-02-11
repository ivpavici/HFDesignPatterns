using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        internal IFlyBehavior flyBehavior;
        internal IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All duck's float, even fake ones!");
        }
    }
}
