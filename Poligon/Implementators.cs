using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Poligons
{
    public class SolidImplementator : ILineImplementationable
    {
        public Color Color { get; set; }
        public int Width { get; set; }

        public void Plot2D(params Point[] points)
        {
            new ConsProxy().GetGraphics().DrawPolygon(new Pen(Color, Width), points);
        }
    }

    public class DashImplementator : ILineImplementationable
    {
        public Color Color { get; set; }
        public int Width { get; set; }

        public System.Drawing.Drawing2D.DashStyle DashStyle { get; set; }

        public void Plot2D(params Point[] points)
        {
            Pen p = new Pen(Color, Width);
            p.DashStyle = DashStyle;
            new ConsProxy().GetGraphics().DrawPolygon(p, points);
        }
    }

    public class BrushImplementator : ILineImplementationable
    {
        public Color Color { get; set; }
        
        public void Plot2D(params Point[] points)
        {
            new ConsProxy().GetGraphics().FillPolygon(new SolidBrush(Color), points);
        }
    }








}
