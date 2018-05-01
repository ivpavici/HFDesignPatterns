using System;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 
    /// The Template Method Pattern defines the skeleton of an algorithm in a method, deffering some steps
    /// to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without 
    /// changing the algorithm's structure.
    /// 
    /// DESIGN PRINCIPLES USED:
    /// 
    /// 1) The Hollywood Principle - Don't call us, we'll call you.
    ///     - The superclasses are running the show, they call the subclasses when needed
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.prepareRecepie();

            Console.WriteLine("\n");

            var coffee = new Coffee();
            coffee.prepareRecepie();
        }
    }
}
