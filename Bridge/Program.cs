<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            Line l = new Line { Start = new Point(10, 20), End = new Point(30, 40), implement = new SolidLineImplement() };

            l.Draw();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            Line l = new Line { Start = new Point(10, 20), End = new Point(30, 40), implement = new SolidLineImplement() };

            l.Draw();
        }
    }
}
>>>>>>> 34a0ba9b576be165f92221286a65aec0c038d6ca
