using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraficsC;

namespace ConsoleApp2
{
    public class ConsProxy : IGrapphics
    {
        private Lazy<ConsoleGraphics> consoleGraphics = new Lazy<ConsoleGraphics>();

        private Graphics graphics = null;

        public Graphics GetGraphics()
        {
            if (graphics == null) {
                graphics = consoleGraphics.Value.GetGraphics();
            }
            return graphics;
        }
    }

    public class Poligon:IDrawable {
       

        private List<Point> points = new List<Point>();
       
        public Poligon(params Point[] p) =>
            points.AddRange(p);

        public ILineImplementationable Implementator { get; set; }
        public void Draw()=>
            Implementator.Plot2D(points.ToArray());
         
    
    }



    public class SolidImplementstor : ILineImplementationable   
    { 
    
        public Color Color { get; set; }
        public int Width { get; set; }

        public void Plot2D(params Point[] points)
        {
            new ConsProxy().GetGraphics().DrawPolygon(new Pen(Color, Width), points);
        }
    }






}
