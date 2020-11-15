using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        class z {

            int i;
           public z(int i) { i = i; }

            public void Print() { Console.WriteLine(i); }
        }

        static void Main(string[] args)
        {
            z x = new z(2);
            x.Print();
            

        }
    }
}
