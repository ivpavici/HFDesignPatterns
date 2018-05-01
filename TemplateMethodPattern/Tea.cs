using System;

namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
