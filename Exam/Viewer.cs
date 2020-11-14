using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    [Serializable]
    public class Viewer: Person
    {
        public Ticket Ticket { get; protected set; }

        public Viewer() { }

        public Viewer(string name, string surname, int age, string phoneNumber) : base(name, surname, age, phoneNumber) {  }

        public void BuyTicket(Ticket t) { Ticket = t; }

        public override string ToString() => base.ToString()+Ticket?.ToString();
       
    }

    [Serializable]
    public class RegularViewer: Viewer
    {

        public int NumberOfVisits { get; set; } = 0;

        public RegularViewer() { }
        public RegularViewer(string name, string surname, int age, string phoneNumber) : base(name, surname, age, phoneNumber) { }
        public RegularViewer(Viewer viewer) : base(viewer.Name, viewer.Surname, viewer.Age, viewer.PhoneNumber) { }

        public override string ToString() => $"{Name} {Surname}";

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is RegularViewer))
                return false;
            RegularViewer e = obj as RegularViewer;
            return this == e;
        }

        public override int GetHashCode() => this.ToString().GetHashCode();
        
        public static bool operator ==(RegularViewer a, RegularViewer b) => a.Name == b.Name && a.Surname == b.Surname;
        public static bool operator !=(RegularViewer a, RegularViewer b) => !(a.Name == b.Name && a.Surname == b.Surname);
        public static bool operator >(RegularViewer a, RegularViewer b) => a.NumberOfVisits > b.NumberOfVisits;
        public static bool operator <(RegularViewer a, RegularViewer b) => a.NumberOfVisits < b.NumberOfVisits;

    }

  
}
