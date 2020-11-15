using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ILineImplementationable
    {
        void Plot2D(Point start, Point end);
    }
}
