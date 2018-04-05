namespace FactoryMethodPattern.ChicagoStylePizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum TOmato Sauce";

            toppings.Add("Shredded Mozarella Cheese");
        }

        public override void Cut()
        {
            System.Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
