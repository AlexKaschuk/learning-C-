using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RandomAdapter :  IRandomble<int>
    {
        //public int RandomValue(int from, int to) => base.Next(from, to);

        Random r = new Random();

        public int RandomValue(int from, int to) => r.Next(from, to);
    }
}
