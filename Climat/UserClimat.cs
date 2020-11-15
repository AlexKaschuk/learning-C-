using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climat
{
    public static class UserClimat
    {
        public static void ControlTemperature(double lowerLimit, double upperLimit, IMeasurable sensor) 
        {
            Console.WriteLine(sensor.ShowTemperatureInC() >= upperLimit ? $"temperature is {sensor.ShowTemperatureInC():F2}C need to cool the room"
                : sensor.ShowTemperatureInC() <= lowerLimit ? $"temperature is {sensor.ShowTemperatureInC():F2}C need to heat the room" 
                : $"temperature is {sensor.ShowTemperatureInC():F2}C temperature within normal limits");
        }
    }
}
