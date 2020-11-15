using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public sealed class Coffe : ICoffeble
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public Coffe(string name, decimal price) { Name = name; Price = price; }

        public Coffe() { }

        public override string ToString() => $"coffe {Name,-20} : price {Price, 10:F2}";
    }
}
