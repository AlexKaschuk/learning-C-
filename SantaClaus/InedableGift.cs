using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    abstract public class AbstractInedibleGift
    {
        public abstract string InedibleGiftName();
    }


    public class GoodInedibleGift : AbstractInedibleGift 
    {
        public override string InedibleGiftName() => $"a toy";
    }


    public class BadInedibleGift : AbstractInedibleGift
    {
        public override string InedibleGiftName() => $"a rod";

    }

}
