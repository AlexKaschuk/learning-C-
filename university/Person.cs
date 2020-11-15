using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace university
{


    public class Person
    {
        private const int idLen = 10;
        static long personCounter;
        private readonly long id;
        private string name;
        public string Surname { get; set; }
        public byte Age {
            get { return (byte)((DateTime.Today.Year - Birthday.Year) - 1 + (DateTime.Today.Month > Birthday.Month || DateTime.Today.Month == Birthday.Month && DateTime.Today.Day >= Birthday.Day ? 1 : 0)); }
        }
        private System.DateTime birthday;
        public Gender Gender { get; set; }

        static Person() {

            personCounter = 1;
        }

        public Person(string _Name, string _Surname, DateTime _Birthday, Gender _gender)
        {
            Name = _Name;
            Surname = _Surname;
            Birthday = _Birthday;
            Gender = _gender;
            id = ++personCounter;
        }

        public Person() : this("", "", new DateTime(1985, 12, 01), default(Gender)) { }

        public string Id {
            get {
                return new string('0', idLen - id.ToString().Length) + id;
            }
        }

        public string Name {
            get { return name; }
            set {
                if (value.Where(x => char.IsNumber(x)).Count() != 0 || value.Where(x => char.IsSeparator(x)).Count() != 0)
                    throw new Exception("num");
                else
                    name = value;
            }
        }

        public System.DateTime Birthday {
            get { return birthday; }
            set { birthday = value; }
        }

        public override string ToString() =>
           $"{ToShortString()} birthday: {Birthday.ToShortDateString()}, Age: {Age}, Gender: {Gender}, ";

        public virtual string ToShortString() =>
            $"id {Id,-(idLen)} Name: {Name + ' ' + Surname}";

        public bool this[Gender g]
        {
            get { return g == this.Gender; }
        }

    }
}
