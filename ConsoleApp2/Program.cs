using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraficsC;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Poligon p = new Poligon(new Point(10, 20), new Point(50, 80), new Point(0, 80));
            p.Implementator = new SolidImplementstor { Color = Color.Red, Width = 10 };

            p.Draw();

        }
    }
}
