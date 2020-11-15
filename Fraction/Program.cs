using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction<Int> f = new Fraction<Int>(new Int {value = 1 }, new Int { value = 2 });
            Fraction<Int> f1 = new Fraction<Int>(new Int {value = 1 }, new Int { value = 3 });
            Fraction<Int> f2 = new Fraction<Int>(new Int {value = 1 }, new Int { value = 2 });
            Console.WriteLine(++f);
            Console.WriteLine(f++);
            Console.WriteLine(f);


        }
    }
}
