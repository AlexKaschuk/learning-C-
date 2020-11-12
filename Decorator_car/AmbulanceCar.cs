using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_car
{
    public class AmbulanceCar : CarDecorator
    {

        public string Signal { get; set; }

        public AmbulanceCar(ICar car, string signal) : base(car) { Signal = signal; }

        public override string Mark  => base.Mark+ "-ambulance";
        public override string Color  => "white with red cross"; 
        public override CarType CarType => base.CarType; 

        public override string ToString() => $"car mark: {Mark}, color: {Color}, type: {CarType}, equipped with a {Signal}";
    }
}
