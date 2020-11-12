using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_XML
{
    public class Person
    {

        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }

        public Person(string name, string surname,  string phoneNumber) { Name = name; Surname = surname;  PhoneNumber = phoneNumber; }

        public override string ToString() => $"name {Name} surname {Surname} phone number {PhoneNumber}";
        
    }
}
