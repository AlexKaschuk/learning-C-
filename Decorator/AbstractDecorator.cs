using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CoffeDecorator : ICoffeble
    {

        protected ICoffeble coffe;

        public CoffeDecorator(ICoffeble coffe) => this.coffe = coffe;

        public virtual string Name => coffe.Name;

        public virtual decimal Price => coffe.Price;

        public override string ToString() => $"coffe {Name,-20} : price {Price,10:F2}";

    }
}
