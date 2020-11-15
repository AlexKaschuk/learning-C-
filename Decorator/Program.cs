using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {


            ICoffeble coffe = new Coffe("Arabica", 25.50m);

            Console.WriteLine(coffe.ToString());

            ICoffeble ddec1 = new MilkDecorator(coffe, 5.00m);
            Console.WriteLine(ddec1.ToString());

            ICoffeble ddec2 = new Shugar(ddec1, 1.00m);
            Console.WriteLine(ddec2.ToString());



        }
    }
}
