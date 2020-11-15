using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            ComplexNum z = new ComplexNum(3, 2);

            Console.WriteLine("z = {0}", z);
            ComplexNum z1;


            z1 = z - (z * z * z + 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);

            Console.WriteLine(z == z1);


            Console.WriteLine(z.Equals(z1));





        }
    }
}
