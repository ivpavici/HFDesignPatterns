using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 
    /// The Decorator pattern attaches additional responsibilities to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) Classes should be open for extension, but closed for modification
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
        }
    }
}
