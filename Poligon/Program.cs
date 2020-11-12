using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Poligons
{
    class Program
    {
        static void Main(string[] args)
        {
            Poligon p = new Poligon(new Point(110, 30), new Point(30, 180), new Point(190, 180));
            //p.Implementator = new SolidImplementator { Color = Color.Red, Width = 10 };
            //p.Implementator = new BrushImplementator { Color = Color.White };

            //p.Implementator = new DashImplementator { Color = Color.Red, Width = 10, DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            //p.Draw();


            CompositeFigure cf = new CompositeFigure();
            cf.AddPoligons(new Poligon(new Point(110, 30), new Point(30, 180), new Point(190, 180)),
                new Poligon(new Point(80, 30), new Point(60, 80), new Point(100, 180)), new Poligon(new Point(30, 180), new Point(190, 180), new Point(190, 280), new Point(30, 280)));

            //cf.Implementator = new BrushImplementator { Color = Color.White };

            //cf.Implementator = new DashImplementator { Color = Color.Red, Width = 10, DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

            cf.Implementator = new SolidImplementator { Color = Color.Red, Width = 10 };
            cf.DrawFigure();
        }
    }
}
