using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public Person() { }

        public Person(string name, string surname, int age, string phoneNumber) { Name = name; Surname = surname; Age = age; PhoneNumber = phoneNumber; }

        public override string ToString() => $"{Name} {Surname}\n";


    }
}
