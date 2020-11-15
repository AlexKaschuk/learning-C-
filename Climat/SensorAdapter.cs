using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climat
{
    public class SensorAdapter : IMeasurable
    {
        Sensor mySensor = new Sensor();
        public double ShowTemperatureInC() => (mySensor.Temperature - 32) * 5 / 9;
    }
}
