using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp2
{
    public interface IDrawable
    {
        void Draw();
    }

    public interface ILineImplementationable
    {
        void Plot2D(params Point[] points);
    }
}
