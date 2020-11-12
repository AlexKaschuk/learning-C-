using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StructPattern
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public class UpperCaseAttribute:Attribute
    {
        public bool IsUpperCase { get; private set; }

        public UpperCaseAttribute(bool isUpperCase) =>
            IsUpperCase = isUpperCase;

        public UpperCaseAttribute() { } 


    }
}
