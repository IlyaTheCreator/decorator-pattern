using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public abstract class Beverage
    {
        readonly double _basePrice = 8.99;
        readonly double _milkPrice = 0.49;
        readonly double _soyPrice = 0.35;
        readonly double _mochaPrice = 1.35;
        readonly double _whipPrice = 0.99;

        public string Description { get; set; }
        public int Milk { get; set; }
        public int Soy { get; set; }
        public int Mocha { get; set; }
        public int Whip { get; set; }

        public virtual double Cost() {
            double total = _basePrice;

            if (HasMilk())
            {
                total += Milk * _milkPrice;
            }

            if (HasMocha())
            {
                total += Mocha * _mochaPrice;
            }

            if (HasSoy())
            {
                total += Soy * _soyPrice;
            }

            if (HasWhip())
            {
                total += Whip * _whipPrice;
            }

            return total;
        }

        public bool HasMilk() {
            return Milk > 0;
        }

        public bool HasSoy()
        {
            return Soy > 0;
        }

        public bool HasMocha()
        {
            return Mocha > 0;
        }

        public bool HasWhip()
        {
            return Whip > 0;
        }
    }
}
