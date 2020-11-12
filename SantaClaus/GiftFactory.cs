using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    abstract public class GiftFactory
    {
        public abstract AbstractEdibleGift CreateEdibleGift();
        public abstract AbstractInedibleGift CreateInedibleGift();

    }


     public class GoodGiftFactory: GiftFactory
    {
        public override AbstractEdibleGift CreateEdibleGift() => new GoodEdibleGift();
        public override AbstractInedibleGift CreateInedibleGift() => new GoodInedibleGift();

    }

    public class BadGiftFactory : GiftFactory
    {
        public override AbstractEdibleGift CreateEdibleGift() => new BadEdibleGift();
        public override AbstractInedibleGift CreateInedibleGift() => new BadInedibleGift();

    }

}
