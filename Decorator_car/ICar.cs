using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_car
{
    public interface ICar
    {
        string Mark { get;  }

        string Color { get;  }

        CarType CarType { get;  }

     
    }
}
