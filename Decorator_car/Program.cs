using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_car
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar myCar = new Car("Vw","Black",CarType.Minibus);

            Console.WriteLine(myCar.ToString());

            ICar amb = new AmbulanceCar(myCar, "siren");


            Console.WriteLine(amb.ToString());


        }
    }
}
