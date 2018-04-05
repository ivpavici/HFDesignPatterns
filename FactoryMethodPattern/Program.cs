using System;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 
    /// The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide
    /// which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYStylePizzaStore();
            var chicagoStore = new ChicagoStylePizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + '\n');
        }
    }
}
