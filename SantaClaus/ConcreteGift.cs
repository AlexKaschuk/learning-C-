using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
   public class ConcreteGift
    {
        public AbstractEdibleGift EdibleGift { get; set; }
        public AbstractInedibleGift InedibleGift { get; set; }

        public void ShowGifts() => Console.WriteLine($"Santa Claus gave to you {EdibleGift.EdibleGiftName()} and {InedibleGift.InedibleGiftName()}");

    }
}
