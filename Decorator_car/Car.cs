using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_car
      
{
    public enum CarType { Sedan, Limusine, Universal, Rodster, Crossover, Minibus, Bus, truck }
    public class Car: ICar
    {
        public string Mark { get;  }

        public string Color { get;  }

        public CarType CarType { get;  }

        public Car() { }
        public Car(string mark, string color, CarType carType) { Mark = mark;  Color = color; CarType = carType; }

        public override string ToString() => $"car mark: {Mark}, color: {Color}, type: {CarType}";



    }
}
