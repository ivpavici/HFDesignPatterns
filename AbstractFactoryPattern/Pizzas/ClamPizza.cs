using AbstractMethodPattern;
using System;

namespace AbstractFactoryPattern.Pizzas
{
    public class ClamPizza: Pizza
    {
        IPizzaIngredientFactory pizzaIngredientsFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientsFactory)
        {
            this.pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing" + name);
            dough = pizzaIngredientsFactory.createDough();
            sauce = pizzaIngredientsFactory.createSauce();
            cheese = pizzaIngredientsFactory.createChesse();
            clam = pizzaIngredientsFactory.createClam();
        }
    }
}
