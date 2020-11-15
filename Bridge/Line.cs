using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bridge
{
    public sealed class Line: IDrawable
    {
        public ILineImplementationable implement { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }

        public void Draw() =>
            implement.Plot2D(Start, End);
        
    }
}
