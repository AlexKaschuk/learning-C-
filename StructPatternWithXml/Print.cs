using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace StructPattern
{
    public static class Printer
    {
        public static void Print<T>(T obj, TextWriter wr) {
            Type type = typeof(T);
            UpperCaseAttribute[] attr = type.GetCustomAttributes(typeof(UpperCaseAttribute)) as UpperCaseAttribute[];
            foreach (UpperCaseAttribute item in attr) {
                if (item.IsUpperCase)
                {
                    wr.WriteLine(obj.ToString().ToUpper());
                    return;
                }
                wr.WriteLine(obj.ToString());
            }
        }
    }
}
