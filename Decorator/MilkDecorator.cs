using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkDecorator : CoffeDecorator
    {
        public decimal MilkPrice { get; private set; }

        public MilkDecorator(ICoffeble coffe, decimal milkPrice) : base(coffe) { MilkPrice = milkPrice; }

        public override string Name => base.Name + " with milk";

        public override decimal Price => base.Price + MilkPrice;

        public override string ToString() => $"coffe {Name,-20} : price {Price,10:F2}";

    }
}
