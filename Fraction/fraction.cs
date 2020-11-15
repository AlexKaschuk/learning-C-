using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Fraction<T>: IComparable<Fraction<T>>
    where T : struct, IArithmeticable<T>, IComparable<T>
    {
        public T Numerator { get; private set; } 
        public T Denominator { get; private set; }

        public Fraction(T numerator, T denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString() => $"{Numerator}/{Denominator}";

        public static Fraction<T> operator +(Fraction<T> x, Fraction<T> y) => 
            new Fraction<T>((x.Numerator.Multiply(y.Denominator)).Add((x.Denominator).Multiply(y.Numerator)), (x.Denominator.Multiply(y.Denominator)));

        //дома перегрузити решту операторів

        public static bool operator <(Fraction<T> x, Fraction<T> y)=>(x.Numerator.Multiply(y.Denominator)).CompareTo(y.Numerator.Multiply(x.Denominator)) < 0;
        public static bool operator >(Fraction<T> x, Fraction<T> y)=>(x.Numerator.Multiply(y.Denominator)).CompareTo(y.Numerator.Multiply(x.Denominator)) > 0;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fraction<T>))
                return false;
            Fraction<T> e = (Fraction<T>)obj;
            //return Numerator.Multiply(e.Denominator).CompareTo(Denominator.Multiply(e.Numerator)) == 0;
            return this.CompareTo(e)==0;   
        }

        public override int GetHashCode() => (Numerator, Denominator).GetHashCode();

        public int CompareTo(Fraction<T> other) =>
            Numerator.Multiply(other.Denominator).CompareTo(Denominator.Multiply(other.Numerator));

        public static bool operator ==(Fraction<T> x, Fraction<T> y) => x.Equals(y);
        public static bool operator !=(Fraction<T> x, Fraction<T> y) => !x.Equals(y);

        public static Fraction<T> operator ++(Fraction<T> x) =>
            new Fraction<T>(x.Numerator.Add(x.Denominator), x.Denominator);

        public static Fraction<T> operator --(Fraction<T> x) =>
            new Fraction<T>(x.Numerator.Subtract(x.Denominator), x.Denominator);
        public static bool operator true(Fraction<T> x) => x.Numerator.CompareTo(default(T))!=0;
        public static bool operator false(Fraction<T> x) => x.Numerator.CompareTo(default(T)) == 0;

        //public static implicit operator double(Fraction<T> x)=> (double)x.Numerator.Divide(x.Denominator);

    }
}
