using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClaus
{
    class Program
    {
        static void Main(string[] args)
        {

            Santa SantaClaus = Santa.Instance();
            ConcreteGift g = SantaClaus.GiveAPresent();
            g.ShowGifts();
            SantaClaus.AddLetters(9, 5);
            g = SantaClaus.GiveAPresent();
            g.ShowGifts();

        }
    }
}
