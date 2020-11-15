using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myC
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


            CultureInfo ci = new CultureInfo("uk-UA");
            ci.NumberFormat.CurrencySymbol = "\u20B4";
            
            //foreach (CultureInfo item in CultureInfo.GetCultures(CultureTypes.AllCultures)) {
            //    Console.WriteLine(item);
            //};

           
            //double a, b;
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());

            
            //double x = Equation.linearEquation(in a, in b);
            //Console.WriteLine($"x= {x}");

            var m = Equation.squareEquation(1, 2, -1);
            Console.WriteLine($"x1= {m.x1} x2 = {m.x2}");
        }
    }
}
