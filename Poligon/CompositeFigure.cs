using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Poligons
{
    public class CompositeFigure
    {
        public List<Poligon> pol = new List<Poligon>();

        public ILineImplementationable Implementator { get; set; }

        public void AddPoligons(params Poligon[] p) => pol.AddRange(p);

        public void DrawFigure() {
            foreach (Poligon item in pol) {
                item.Implementator = Implementator;
                item.Draw();
            }
        
        }

        

    }
}
