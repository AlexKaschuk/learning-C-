using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Shugar: CoffeDecorator
    {
        public decimal ShugarPrice { get; private set; }

        public Shugar(ICoffeble coffe, decimal sugarPrice) : base(coffe) { ShugarPrice = sugarPrice; }

        public override string Name => base.Name + " with shugar";

        public override decimal Price => base.Price + ShugarPrice;

        public override string ToString() => $"coffe {Name,-20} : price {Price,10:F2}";


    }
}
