using System;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        // no final keyword in C#
        public void prepareRecepie()
        {
            BoilWater();
            Brew();
            pourInCup();
            AddCondiments();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        // Hooks can do nothing by default. Subclass can override it but doesn't have to
        // virtual void hook() {}
    }
}
