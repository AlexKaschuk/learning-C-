<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 34a0ba9b576be165f92221286a65aec0c038d6ca
