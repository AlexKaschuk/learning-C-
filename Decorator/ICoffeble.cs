using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface ICoffeble
    {
       string Name { get; }

       decimal Price { get; }
    }
}
