using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Decaf : Beverage
    {
        public override double Cost()
        {
            return base.Cost() + 0.99;
        }
    }
}
