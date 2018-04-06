using System;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createChesse()
        {
            return new ReggianoCheese();
        }

        public IClams createClam()
        {
            throw new NotImplementedException();
        }

        public IDough createDough()
        {
            throw new NotImplementedException();
        }

        public IPepperoni createPepperoni()
        {
            throw new NotImplementedException();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
