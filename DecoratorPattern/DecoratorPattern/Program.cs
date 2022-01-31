using DecoratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HouseBlend houseBlend = new HouseBlend { Whip = 1, Milk = 1 };
            DarkRoast darkRoast = new DarkRoast { Mocha = 1 };
            Decaf decaf = new Decaf { Soy = 1 };
            Espresso espresso = new Espresso { Whip = 2 };

            Console.WriteLine($"${houseBlend.Cost()}");
            Console.WriteLine($"${darkRoast.Cost()}");
            Console.WriteLine($"${decaf.Cost()}");
            Console.WriteLine($"${espresso.Cost()}");

            Console.ReadLine();
        }
    }
}
