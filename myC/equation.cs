using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace myC
{
    static class Equation
    {
        public static double linearEquation(in double a, in double b) {
            return -b / a;
          }
        public static (double x1, double x2) squareEquation(in double a, in double b, double c)
        {
           double x1, x2;
           x1 =(-b + Math.Sqrt(b*2 - 4*a*c)) /2*a;
           x2 = (-b - Math.Sqrt(b * 2 - 4 * a * c)) / 2 * a;
           return (x1, x2);

        }
    }
}
