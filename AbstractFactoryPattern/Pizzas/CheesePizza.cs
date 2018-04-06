using AbstractMethodPattern;
using System;

namespace AbstractFactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientsFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientsFactory)
        {
            this.pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing" + name);
            //dough = pizzaIngredientsFactory.createDough();
            sauce = pizzaIngredientsFactory.createSauce();
            cheese = pizzaIngredientsFactory.createChesse();
        }
    }
}
