<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SolidLineImplement : ILineImplementationable
    {
        public void Plot2D(Point start, Point end)=>
             Console.WriteLine($"solid line from {start} to {end}");
        
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
    public class SolidLineImplement : ILineImplementationable
    {
        public void Plot2D(Point start, Point end)=>
             Console.WriteLine($"solid line from {start} to {end}");
        
    }
}
>>>>>>> 34a0ba9b576be165f92221286a65aec0c038d6ca
