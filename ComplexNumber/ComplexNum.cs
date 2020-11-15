using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNum
    {
        private int Re { get; set; } = 0;

        private int Im { get; set; } = 0;

        private int imaginaryUnit { get; } = -1;

        private int z;

        public int Z { get => Re + Im * imaginaryUnit; private set=>z=value; }
        public ComplexNum(int x, int y) { Re = x; Im = y; }
        public ComplexNum(int x) { Z = x; Re = x + 1; Im = 1; }


        public static ComplexNum operator +(ComplexNum x, ComplexNum y) => new ComplexNum ((x.Re + y.Re), (x.Im + y.Im));
        public static ComplexNum operator +(int x, ComplexNum y) => new ComplexNum (x + y.Z);
        public static ComplexNum operator +(ComplexNum y, int x) => new ComplexNum ( y.Z+x);
        
        public static ComplexNum operator -(ComplexNum x, ComplexNum y) => new ComplexNum ((x.Re - y.Re), (x.Im - y.Im));
        public static ComplexNum operator -(int x, ComplexNum y) => new ComplexNum(x-y.Z);
        public static ComplexNum operator -(ComplexNum y, int x) => new ComplexNum (y.Z-x);

        public static ComplexNum operator *(ComplexNum x, ComplexNum y) => new ComplexNum ((x.Re * y.Re - x.Im * y.Im), (x.Im * y.Re + x.Re * y.Im));
        public static ComplexNum operator *(int x, ComplexNum y) => new ComplexNum(x*y.Z);
        public static ComplexNum operator *( ComplexNum y, int x) => new ComplexNum(x*y.Z);

        public static ComplexNum operator /(ComplexNum x, ComplexNum y) => new ComplexNum (((x.Re * y.Re + x.Im * y.Im)/(y.Re*y.Re+y.Im*y.Im)), ((x.Im * y.Re - x.Re * y.Im)/ (y.Re * y.Re + y.Im * y.Im)));
        public static ComplexNum operator /(int x, ComplexNum y) => new ComplexNum(x/y.Z);
        public static ComplexNum operator /( ComplexNum y, int x) => new ComplexNum(y.Z/x);

        public static bool operator ==(ComplexNum x, ComplexNum y) => x.Re == y.Re && x.Im == y.Im;
        public static bool operator !=(ComplexNum x, ComplexNum y) => !(x.Re == y.Re && x.Im == y.Im);


        public override string ToString() => $"{Z}";

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ComplexNum))
                return false;
            ComplexNum e = obj as ComplexNum;
            return this == e;
        }

        public override int GetHashCode()=>(Re, Im, Z).GetHashCode();
        
    }
}
