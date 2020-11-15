using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climat
{
    public class Sensor
    {
        public double Temperature { get; }

        public Sensor() => Temperature = new Random().NextDouble() * 100;//це сторонній інтерфейс визначення температури)))
    }
}
