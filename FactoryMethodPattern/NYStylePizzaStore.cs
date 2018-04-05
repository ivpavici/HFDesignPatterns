using FactoryMethodPattern.NYStylePizzas;

namespace FactoryMethodPattern
{
    class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return null;
            }

            return null;
        }
    }
}
