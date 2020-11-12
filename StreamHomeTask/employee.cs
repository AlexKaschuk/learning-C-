using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamHomeTask
{
    public class Employee
    {
        public int Id { get; private set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        private static int idCounter = 1000001;

        public long PhoneNumber;

        public Employee() {
            Id = idCounter;
            ++idCounter;
        }

        public Employee(string name, string surname, long phone) {
            Name = name;
            Surname = surname;
            Id = idCounter;
            PhoneNumber = phone;
            ++idCounter;
        }

        public override string ToString() => $"{Id},{Name},{Surname},{PhoneNumber}";

        public void FromString(string str) {
            string[] tmp = str.Split(',',' ');
            Id = Convert.ToInt32(tmp[0]);
            Name = tmp[1];
            Surname = tmp[2];
            PhoneNumber = Convert.ToInt64(tmp[3]);
        }
    }
}
