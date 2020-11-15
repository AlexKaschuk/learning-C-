using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IArithmeticable<T>
    {
        T Add(T other);
        T Subtract(T other);
        T Divide(T other);
        T Multiply(T other);
    }
}
