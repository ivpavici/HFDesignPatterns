using System;

namespace StrategyPattern.Quack
{
    class RealQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
