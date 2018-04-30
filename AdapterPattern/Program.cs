using System;

namespace AdapterPattern
{
    /// <summary>
    /// 
    /// The Adapter Pattern converts the interface of a class into another interface the clients expect.
    /// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();

            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says: ");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe Duck says: ");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nThe turkeyAdapter says:");
            testDuck(turkeyAdapter);
        }

        static void testDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
