using StrategyPattern.Fly;

namespace StrategyPattern
{
    /// <summary>
    /// 
    /// The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) Identify the aspects of your app that vary and separate them from what stays the same
    /// 2) Program to an interface, not an implementation
    /// 3) Favor composition over inheritance
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();

            mallard.PerformFly();
            mallard.PerformQuack();

            var modelDuck = new ModelDuck();

            modelDuck.PerformQuack();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyRocketPowered());
            modelDuck.PerformFly();
        }
    }
}
