using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   


    public struct Int : IArithmeticable<Int>, IComparable<Int>
    {
        public int value { get; set; }

        public Int Add(Int other) => new Int { value = value + other.value };
       
        public int CompareTo(Int other)=> value.CompareTo(other.value);
        
        public Int Divide(Int other) => new Int { value = value - other.value };

        public Int Multiply(Int other) => new Int { value = value * other.value };
        
        public Int Subtract(Int other) => new Int { value = value / other.value };

        public override string ToString() => value.ToString();

        


    }
}
