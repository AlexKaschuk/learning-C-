using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    public class Santa
    {

        static Santa unique;

        private Elf myElf = new Elf();
        private bool IsAffable { get; set; }
        protected Santa() {}

        public static Santa Instance()
        {
            if (unique == null) unique = new Santa();
            return unique;
        }

        public void AddLetters(int goodJobs, int badJobs) =>
            IsAffable = goodJobs > badJobs ? true : false;
  
        public ConcreteGift GiveAPresent() =>
             IsAffable == true ? myElf.MakeGift(new GoodGiftFactory()) : myElf.MakeGift(new BadGiftFactory());
    }
}
