using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    public class Elf
    {
        public ConcreteGift MakeGift(GiftFactory factory) => 
            new ConcreteGift { EdibleGift = factory.CreateEdibleGift(), InedibleGift = factory.CreateInedibleGift() };
    }

}
