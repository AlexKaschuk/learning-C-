using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_car
{
    public abstract class CarDecorator: ICar
    {
        protected ICar Car;
        public CarDecorator(ICar car) => Car = car;
        public virtual string Mark { get => Car.Mark; }
        public virtual string Color { get => Car.Color; }
        public virtual CarType CarType { get => Car.CarType; }
        public override string ToString() => $"car mark: {Mark}, color: {Color}, type: {CarType}";

    }
}
