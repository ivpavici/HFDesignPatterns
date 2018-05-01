using System;

namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
