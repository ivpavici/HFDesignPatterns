using AbstractMethodPattern;

namespace AbstractFactoryPattern
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);
    }
}
