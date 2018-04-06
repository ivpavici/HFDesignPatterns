using System;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// The Abstract Factory Pattern provides an interface for creating families of related or dependent objects
    /// without specifying their concrete classes.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) THE DEPENDENCY INVERSION PRINCIPLE: Depend upon abstractions. Do not depend upon concrete classes.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NYStylePizzaStore();

            var pizza = nyStore.CreatePizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + '\n');
        }
    }
}
