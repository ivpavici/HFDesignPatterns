using AbstractFactoryPattern.Ingredients;
using System;

namespace AbstractMethodPattern
{
    public abstract class Pizza
    {
        protected string name;

        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies[] veggies;
        protected ICheese cheese;
        protected IPepperoni peppreoni;
        protected IClams clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
