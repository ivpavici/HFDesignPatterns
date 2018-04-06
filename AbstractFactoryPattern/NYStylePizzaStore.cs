using AbstractFactoryPattern.Pizzas;
using AbstractMethodPattern;

namespace AbstractFactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Prepare();
                pizza.SetName("NY Style Cheese pizza");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("NY Style Clam pizza");
            }

            return pizza;
        }
    }
}
