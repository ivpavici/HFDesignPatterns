using FactoryMethodPattern.ChicagoStylePizzas;

namespace FactoryMethodPattern
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return null;
            }

            return null;
        }
    }
}
