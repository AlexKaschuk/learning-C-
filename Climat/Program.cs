using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climat
{
    class Program
    {
        static void Main(string[] args)
        {

            UserClimat.ControlTemperature(15, 25, new SensorAdapter());
        }
    }
}
