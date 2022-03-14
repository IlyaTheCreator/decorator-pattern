using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Condiments
{
    public class Milk : CondimentDecorator
    {
        Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 1.25;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }
    }
}
