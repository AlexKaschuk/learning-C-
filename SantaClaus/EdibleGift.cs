using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    abstract public class AbstractEdibleGift
    {
        public abstract string EdibleGiftName();
    }

    public class GoodEdibleGift : AbstractEdibleGift
    {
        public override string EdibleGiftName() => $"a sweets";
        
    }


    public class BadEdibleGift : AbstractEdibleGift
    {
        public override string EdibleGiftName() => $"bitter pills";

    }




}
