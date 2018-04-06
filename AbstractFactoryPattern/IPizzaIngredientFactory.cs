using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern
{
    public interface IPizzaIngredientFactory
    {
        IDough createDough();
        ICheese createChesse();
        ISauce createSauce();
        IClams createClam();
        IVeggies[] createVeggies();
        IPepperoni createPepperoni();
    }
}
